using ImportableMixed;
/****************************** Header ******************************\
Project:      CSV-Preparing-Software

The programm downloads a CSV-File, and reads it, then it should save it and prepare 
the information(calculate Price, add new information and so on). After the preparing is
finished then the file should ne uploaded to a server.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportableMixed
{
    class MainProgram
    {
        static string FILENAME = "InputFile.csv";
        static string NEWFILENAME = "OutputFile.csv";
        static char DELIMITER = '|';
        static char WRITEDELIMITER = ';';
        static Tire[] tires;
        static Tire[] lastImp;
        static string lastImportFileName = "";

        public static void Main(string[] args)
        {
            /*  For Windows-Application comment out this lines
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
             */

            /* For Consolen-Application comment out this lines
            Console.SetBufferSize(300, 400);
            ReadFromCsv(FILENAME, false, true);
            CheckWidth();
            CalculationPrice(tires);
            Write(false, NEWFILENAME);
            Console.ReadLine();
             */
        }

        public static Tire[] Tires
        {
            get { return MainProgram.tires; }
            set { tires = value; }
        }

        #region TestDownloading
        private static void downloadtest()
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://https://www.tyre24.com/at/de/export/download/t/MQ==/c/Mg==/");
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("157576", "robert&andrej2015");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            Console.WriteLine(reader.ReadToEnd());

            Console.WriteLine("Download Complete, status {0}", response.StatusDescription);

            reader.Close();
            response.Close();
        }

        private static void DownloadCsv()
        {
            string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Uri adress = new Uri("https://www.tyre24.com//at/de/user/login/userid/157576/password/robert&andrej2015/page/L2V4cG9ydC9kb3dubG9hZC90L01RPT0vYy9NZz09Lw==");
            WebClient webClient = new WebClient();
            webClient.UseDefaultCredentials = true;
            Console.WriteLine(webClient.GetLifetimeService());
            //webClient.DownloadFile(adress.AbsoluteUri,"157576_at.zip");

            //ZipFile.ExtractToDirectory(System.IO.Path.GetDirectoryName(filePath) + "\\" + "157576_at.zip", System.IO.Path.GetDirectoryName(filePath));
            File.Move(System.IO.Path.GetDirectoryName(filePath) + "\\tmp\\157576_at.csv", System.IO.Path.GetDirectoryName(filePath) + "\\tmp\\157576_at.csv");

        }
        #endregion 

        /// <summary>
        /// Die eingelesenen und aufbereiteten Reifeninformationen werden in eine csv-Datei gespeicher!
        /// </summary>
        /// <param name="tires">Array der eingelesenen Reifen</param>
        public static void Write(bool timestamp, string csvFolder)
        {
            //Das derzeitige Verzeichniss suchen
            string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string folderPath = System.IO.Path.GetDirectoryName(csvFolder);
            StreamWriter file, time;

            //Falls Importstempel drauf soll
            if (timestamp == true)
            {
                time = new StreamWriter((csvFolder + "\\" + DateTime.Now.ToShortDateString() + ".txt"), false, Encoding.UTF8);
                file = new StreamWriter((csvFolder + "\\" + "Export_" + DateTime.Now.ToShortDateString() + ".csv"), false, Encoding.UTF8);
            }
            else
            {
                //Datei im selben Verzeichnis erstellen
                file = new StreamWriter((csvFolder + "\\" + NEWFILENAME), false, Encoding.UTF8);
            }

            try
            {
                for (int i = 0; i < tires.Length; i++)
                {
                    string line = Convert.ToString(tires[i].id) + WRITEDELIMITER + tires[i].article_id + WRITEDELIMITER + tires[i].description + WRITEDELIMITER + tires[i].description_2 + WRITEDELIMITER + tires[i].salePrice + WRITEDELIMITER + tires[i].price4 + WRITEDELIMITER + tires[i].avg_price + WRITEDELIMITER + tires[i].anonyme_price + WRITEDELIMITER + tires[i].rvo_price + WRITEDELIMITER + tires[i].availability + WRITEDELIMITER + tires[i].manufacturer_int + WRITEDELIMITER + tires[i].img + WRITEDELIMITER + tires[i].image_tn + WRITEDELIMITER + tires[i].info + WRITEDELIMITER + tires[i].manufacturer + WRITEDELIMITER + tires[i].directlink + WRITEDELIMITER + tires[i].tyrelabel_link + WRITEDELIMITER + tires[i].energy_efficiency_index + WRITEDELIMITER + tires[i].wet_grip_index + WRITEDELIMITER + tires[i].noise_index + WRITEDELIMITER + tires[i].noise_decibel + WRITEDELIMITER + tires[i].vehicle_class + WRITEDELIMITER + tires[i].type + WRITEDELIMITER + tires[i].width + WRITEDELIMITER + tires[i].height + WRITEDELIMITER + tires[i].measurement;
                    //In die Datei schreiben!
                    file.WriteLine(line);
                }
                file.Close();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            finally
            {
                file.Close();
            }

        }
        /// <summary>
        /// Verschiedene Eigenschaften aus dem Matchcode herausfiltern
        /// </summary>
        /// <param name="T">Array der eingelesenen Reifen</param>
        public static void CheckWidth()
        {
            double test = 0.0;
            double test1 = 0.0;
            double test2 = 0.0;

            //Die Reifengröße, Reifenbreite, Reifenhöhe bestimmen für , Sommer, Winter, Offroad, Ganzjahresreifen
            for (int i = 0; i < tires.Length; i++)
            {
                //Falls kein Typ vorliegt oder es keiner der Reifentypen ist die wir verwenden möchten nicht aktion durchführen
                if (tires[i].type == null)
                    continue;
                //if ((tires[i].type.Equals("Sommer-Reifen") || tires[i].type.Equals("Winter-Reifen") || tires[i].type.Equals("Offroad-Reifen")) || tires[i].type.Equals("Ganzjahres-Reifen"))
                if (tires[i].article_id.Length > 7)
                {
                    //Falls der Matchcode passt dann...
                    Double.TryParse(tires[i].article_id.Substring(1, 3), out test2);
                    Double.TryParse(tires[i].article_id.Substring(4, 2), out test1);
                    Double.TryParse(tires[i].article_id.Substring(6, 2), out test);
                    if (test2 > 0.0)
                    {
                        tires[i].width = Double.Parse(tires[i].article_id.Substring(1, 3));     //Reifenbreite aus dem Matchcode extrahieren
                    }
                    if (test > 0.0)
                    {
                        tires[i].measurement = Double.Parse(tires[i].article_id.Substring(6, 2));
                    }
                    if (test1 > 0.0)
                    {
                        tires[i].height = Double.Parse(tires[i].article_id.Substring(4, 2));
                    }
                }

            }
        }

        /// <summary>
        /// Daten aus der CSV-Datei ins Programm laden
        /// </summary>
        /// <returns>Array der eingelesenen Reifen</returns>
        public static void ReadFromCsv(string CsvFolder, bool IsLastImport, bool deleteDotTires)
        {
            double result1 = -1.0;
            double result2 = -1.0;
            int inputedElements = 0;

            try
            {
                string[] all;
                if (IsLastImport)
                {
                    //Alles aus der CSV-Datei einlesen
                    all = File.ReadAllLines(System.IO.Path.GetDirectoryName(lastImportFileName) + "\\Export_" + System.IO.Path.GetFileNameWithoutExtension(lastImportFileName) + ".csv", Encoding.Default);
                }
                else
                {
                    //Alles aus der CSV-Datei einlesen
                    all = File.ReadAllLines(CsvFolder + "\\" + "InputFile.csv", Encoding.Default);
                }

                //Array erstellen in der perfekten größe, Überschrift wird dabei überlesen
                Tire[] t = new Tire[all.Length - 1];

                for (int i = 1; i < all.Length; i++)
                {
                    string[] temp;
                    string line = all[i];
                    if (IsLastImport)
                    {
                        temp = line.Split(WRITEDELIMITER);
                    }
                    else
                    {
                        temp = line.Split(DELIMITER);
                    }


                    //Die einzelnen Felder aus der CSV-Laden ins Programm
                    Tire fill = new Tire(Int64.Parse(temp[0]), temp[1], temp[2], temp[3], temp[4], temp[5], temp[6], temp[7], temp[8], temp[9], temp[10], temp[11], temp[12], temp[13], temp[14], temp[15], temp[16], temp[17], temp[18], temp[19], temp[20], temp[21]);

                    //Überprüfen ob es einen Price4 gibt
                    #region Price4
                    Double.TryParse(fill.price, out result1);
                    Double.TryParse(fill.price4, out result2);

                    if (result1 <= 0)
                    {
                        if (result2 <= 0)
                        {
                            fill = null;
                            continue;
                        }
                        else
                        {
                            fill.price = fill.price4;
                        }
                    }
                    else
                    {
                        if (result2 <= 0)
                            fill.price4 = "";
                    }
                    #endregion

                    //Reifentyp herausfiltern
                    #region CheckType

                    if (fill.id == 191082)
                    {
                        continue;
                    }
                    if (fill.article_id == "")
                    {
                        continue;
                    }
                    //Falls die Artikel ID an der 0 Stelle in diesem Fall "s" ist dann handelt es sich um ein Sommer-Reifen usw...
                    if (fill.article_id.Substring(0, 1).ToLower().Equals("s"))
                    {
                        fill.type = "PKW Sommer-Reifen";
                    }
                    else if (fill.article_id.Substring(0, 1).ToLower().Equals("w"))
                    {
                        fill.type = "PKW Winter-Reifen";
                    }
                    else if (fill.article_id.Substring(0, 1).ToLower().Equals("m"))
                    {
                        fill.type = "2 Rad/Quad-Reifen";
                    }
                    else if (fill.article_id.Substring(0, 1).ToLower().Equals("g"))
                    {
                        fill.type = "Ganzjahres-Reifen";
                    }
                    else if (fill.article_id.Substring(0, 1).ToLower().Equals("o"))
                    {
                        fill.type = "Offroad-Reifen";
                    }
                    else if (fill.article_id.Substring(0, 1).ToLower().Equals("l"))
                    {
                        fill.type = "LKW-Reifen";
                    }
                    else if (fill.article_id.Substring(0, 1).ToLower().Equals("b"))
                    {
                        fill.type = "Bagger-Reifen";
                    }
                    else if (fill.article_id.Substring(0, 1).ToLower().Equals("c"))
                    {
                        continue;
                        //Stahlfelgen möchten wir nicht einlesen
                        //fill.type = "Stahlfelgen";
                    }
                    else if (fill.article_id.Substring(0, 1).ToLower().Equals("l"))
                    {
                        fill.type = "Staplfer-Reifen";
                    }
                    else if (fill.article_id.Substring(0, 1).ToLower().Equals("Z") && fill.article_id.Substring(0, 2).ToLower().Equals("ZS"))
                    {
                        fill.type = "Wuchtgewicht";
                    }
                    else if (fill.article_id.Substring(0, 1).ToLower().Equals("Z"))
                    {
                        fill.type = "Schläuche";
                    }
                    else
                    {
                        //Falls kein Reifentyp festgestellt werden konnte...Reifentype = Undefiniert
                        fill.type = "Andere";
                    }
                    #endregion


                    t[inputedElements] = fill;
                    inputedElements++;
                }
                if (deleteDotTires)
                {
                    List<Tire> temporary = new List<Tire>();
                    for (int i = 0; i < inputedElements; i++)
                    {
                        if (t[i].description.ToLower().Contains("dot") || t[i].description_2.ToLower().Contains("dot") || t[i].description.ToLower().Contains("runderneuert") || t[i].description_2.ToLower().Contains("runderneuert") || t[i].description.ToLower().Contains("demo") || t[i].description_2.ToLower().Contains("demo") || t[i].description.ToLower().Contains("rainforced") || t[i].description_2.ToLower().Contains("rainforced") || Convert.ToInt32(t[i].availability) < 20 || t[i].type.Equals("Andere"))
                        {
                            continue;
                        }
                        temporary.Add(t[i]);
                    }
                    if (IsLastImport)
                        lastImp = temporary.ToArray();
                    else
                        tires = temporary.ToArray();
                }
                else
                {
                    Tire[] perfectSize = new Tire[t.Length];
                    for (int i = 0; i < inputedElements; i++)
                    {
                        perfectSize[i] = t[i];
                    }
                    tires = perfectSize;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Die Datei wurde nicht gefunden oder wird gerade Verwendet!");
            }
            catch (IOException i)
            {
                Console.WriteLine("{0}", i.Message);
            }
        }
        /// <summary>
        /// Preis des Reifens aufgrund seines Einkaufpreises berrechnen
        /// </summary>
        /// <param name="tr">Array der eingelesenen Reifen!</param>
        public static Tire[] CalculationPrice(Tire[] tr)
        {
            try
            {
                for (int i = 0; i < tr.Length; i++)
                {
                    //Überprüfen ob es einen Preis für 4 Reifen gibt falls nicht Preis für 1 hernehmen
                    if (tr[i].price4.Length > 0)
                    {
                        //Falls doch wird Preis mit Preis4 überschrieben
                        tr[i].price = (tr[i].price4);
                    }
                    double test = (Double.Parse(tr[i].price.Replace('.', ',')));
                    if (test < 40.0)
                    {
                        tr[i].salePrice = Convert.ToString(((test + 4) * 1.2));
                    }
                    else
                    {
                        tr[i].salePrice = Convert.ToString(((test * 1.1) * 1.2));
                    }
                    tr[i].price = tr[i].price.Replace('.', ',');
                    tr[i].salePrice = Convert.ToString(tr[i].salePrice).Replace(',', '.');

                    #region OldPricing
                    /*
                                //Zuerst wird '.' mit ',' ersetzt dann mal 4 gerrechnet damit man den Preis für 4 Reifen bekommt und + 20% Mwst. daraus setzt sich unser Einkaufpreis zusammen
                                if ((((Double.Parse(tires[i].price.Replace('.',','))) * 4.0) * 1.2 ) <= 200)
                                {
                                    //Falls der Einkaufspreis 200 übersteigt dann 15% draufschlag!
                                    tires[i].salePrice = (((Double.Parse(tires[i].price.Replace('.',',')) * 1.2) * 1.15));
                                }
                                else if ((((Double.Parse(tires[i].price.Replace('.',','))) * 4.0) * 1.2) <= 250)
                                {
                                    //Falls der Einkaufspreis 200 übersteigt dann 14% draufschlag usw...
                                    tires[i].salePrice = ((Double.Parse(tires[i].price.Replace('.', ',')) * 1.2 * 1.14));
                                }
                                else if ((((Double.Parse(tires[i].price.Replace('.',','))) * 4.0) * 1.2) <= 300)
                                {
                                    tires[i].salePrice = ((Double.Parse(tires[i].price.Replace('.', ',')) * 1.2 * 1.13 * 1.0045));
                                }
                                else if ((((Double.Parse(tires[i].price.Replace('.',','))) * 4.0) * 1.2) <= 350)
                                {
                                    tires[i].salePrice = ((Double.Parse(tires[i].price.Replace('.', ',')) * 1.2 * 1.13));
                                }
                                else if ((((Double.Parse(tires[i].price.Replace('.',','))) * 4.0) * 1.2) <= 400)
                                {
                                    tires[i].salePrice = ((Double.Parse(tires[i].price.Replace('.', ',')) * 1.2 * 1.12 * 1.0045));
                                }
                                else if ((((Double.Parse(tires[i].price.Replace('.',','))) * 4.0) * 1.2) <= 450)
                                {
                                    tires[i].salePrice = ((Double.Parse(tires[i].price.Replace('.', ',')) * 1.2 * 1.12));
                                }
                                else if ((((Double.Parse(tires[i].price.Replace('.',','))) * 4.0) * 1.2) <= 500)
                                {
                                    tires[i].salePrice = ((Double.Parse(tires[i].price.Replace('.', ',')) * 1.2 * 1.11 * 1.0045));
                                }
                                else if ((((Double.Parse(tires[i].price.Replace('.',','))) * 4.0) * 1.2) <= 550)
                                {
                                    tires[i].salePrice = ((Double.Parse(tires[i].price.Replace('.', ',')) * 1.2 * 1.110));
                                }
                                else if ((((Double.Parse(tires[i].price.Replace('.', ','))) * 4.0) * 1.2) <= 600)
                                {
                                    tires[i].salePrice = ((Double.Parse(tires[i].price.Replace('.', ',')) * 1.2 * 1.050 * 1.0045));
                                }
                                else
                                {
                                    tires[i].salePrice = ((Double.Parse(tires[i].price.Replace('.', ',')) * 1.2 * 1.10));
                                }
                                tires[i].salePrice = Math.Round(tires[i].salePrice, 2);
                            }
                     */
                    #endregion H
                }
                return tr;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
            return null;
        }

        internal static string LastExport(string csvFolder)
        {
            string[] filePaths = Directory.GetFiles(csvFolder, "*.txt", SearchOption.TopDirectoryOnly);
            string oldString = "01.01.1990";
            for (int i = 0; i < filePaths.Length; i++)
            {
                string newString = System.IO.Path.GetFileNameWithoutExtension(filePaths[i]);

                if (Convert.ToDateTime(newString).CompareTo(Convert.ToDateTime(oldString)) >= 1)
                {
                    oldString = newString;
                    lastImportFileName = filePaths[i];
                }
            }
            return System.IO.Path.GetFileName(oldString);
        }

        public static void JustChanged(bool deleteDotTire)
        {
            ReadFromCsv(lastImportFileName, true, deleteDotTire);
            List<Tire> justChanged = new List<Tire>();
            Tire[] t = CalculationPrice(lastImp);
            justChanged = t.OfType<Tire>().ToList();
            for (int i = 0; i < tires.Length; i++)
            {
                Tire act = tires[i];
                for (int x = 0; x < lastImp.Length; x++)
                {
                    if (act.description.Equals(lastImp[x].description))
                    {
                        if (Convert.ToDouble(act.salePrice) == Convert.ToDouble(lastImp[x].salePrice) && Convert.ToInt32(act.availability) == Convert.ToInt32(lastImp[x].availability))
                        {
                            continue;
                        }
                        justChanged.Add(act);
                    }
                }
            }
            tires = justChanged.ToArray();
        }
    }
}
