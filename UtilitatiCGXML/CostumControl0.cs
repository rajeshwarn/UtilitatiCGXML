﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//Added
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.SS.UserModel;
using NPOI.POIFS.FileSystem;
using NPOI.SS.Util;
using GeoAPI;
using GeoAPI.Geometries;
using NetTopologySuite;
using NetTopologySuite.IO;
using NetTopologySuite.Shape;
using NetTopologySuite.IO.ShapeFile;
using NetTopologySuite.Features;
using DaveChambers.FolderBrowserDialogEx;
using nc;


namespace UtilitatiCGXML
{
    public partial class CostumControl0 : UserControl
    {
        private void tEnabled(bool state)
        {
            checkBox1.Enabled = state;
            button1.Enabled = state;
            button2.Enabled = state;
            button3.Enabled = state;
            button4.Enabled = state;
            button5.Enabled = state;
            button6.Enabled = state;
        }
        private List<string> AllFileListz = new List<string>();
        private List<string> MustFileListz = new List<string>();
        private List<string> RandomListz = new List<string>();
        private List<string> TempFileListz = new List<string>();
        private IEnumerable<string> Random = new List<string>();
        //public DirectoryInfo CostumFolderBrowserDialogPath = new DirectoryInfo("C:\\Temp");
        private string CostumFolderBrowserDialogPath = "";

        //Temp Strings
        public string cadgenno = "";
        public string sector = "";
        public string ie = "";
        public string measarea = "";
        public string parcellegalarea = "";
        public string dif = "";
        public string titleno = "";
        public string landplotno = "";
        public string parcelno = "";
        public string parcelarea = "";
        public string cat = "";
        public string intra = "";
        public string note = "";
        public string notes = "";
        public string nrtopo = "";
        public string nrcf = "";
        public string nrcad = "";
        public string enclosed = "";
        public string persoana = "";
        public string pnotes = "";
        public string buildingid = "";
        public string measuredarea = "";
        public string destinatie = "";
        public string legalbuilding = "";
        public string bnotes = "";
        public string BLA = "";
        public string nivel = "";
        public string legalarea = "";
        public string regtype = "";
        public string sup = "";
        public string deedtype = "";
        public string adresa = "";
        public string UAT_land = "";
        public string defunct = "";
        public string cnp = "";
        public string lbpart = "";
        //

        public CostumControl0()
        {
            InitializeComponent();
            tEnabled(false);
        }
        #region Designer Components
        private void label1_Click(object sender, EventArgs e)
        {
            if (label21.Visible == true)
            {
                label21.Visible = false;
            }

            if (TableLayoutPanel1.Visible == true)
            {
                TableLayoutPanel1.Visible = false;
            }

            if (tableLayoutPanel2.Visible == true)
            {
                tableLayoutPanel2.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }

            if (tableLayoutPanel2.Visible == true)
            {
                tableLayoutPanel2.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (label21.Visible == false)
            {
                label21.Visible = true;
            }

            if (TableLayoutPanel1.Visible == false)
            {
                TableLayoutPanel1.Visible = true;
            }/*
            TableLayoutPanel1.ColumnCount = 4;
            TableLayoutPanel1.RowCount = 5;
            TableLayoutPanel1.Size.Height = 645;
            TableLayoutPanel1.Size.Width = 375;*/
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }

            if (TableLayoutPanel1.Visible == true)
            {
                TableLayoutPanel1.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (tableLayoutPanel2.Visible == false)
            {
                tableLayoutPanel2.Visible = true;
            }

            if (label21.Visible == false)
            {
                label21.Visible = true;
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }

            if (TableLayoutPanel1.Visible == true)
            {
                TableLayoutPanel1.Visible = false;
            }

            if (tableLayoutPanel2.Visible == true)
            {
                tableLayoutPanel2.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (label21.Visible == false)
            {
                label21.Visible = true;
            }

            if (tableLayoutPanel3.Visible == false)
            {
                tableLayoutPanel3.Visible = true;
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }

            if (TableLayoutPanel1.Visible == true)
            {
                TableLayoutPanel1.Visible = false;
            }

            if (tableLayoutPanel2.Visible == true)
            {
                tableLayoutPanel2.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (label21.Visible == false)
            {
                label21.Visible = true;
            }

            if (tableLayoutPanel4.Visible == false)
            {
                tableLayoutPanel4.Visible = true;
            }
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }

            if (TableLayoutPanel1.Visible == true)
            {
                TableLayoutPanel1.Visible = false;
            }

            if (tableLayoutPanel2.Visible == true)
            {
                tableLayoutPanel2.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (label21.Visible == false)
            {
                label21.Visible = true;
            }

            if (tableLayoutPanel5.Visible == false)
            {
                tableLayoutPanel5.Visible = true;
            }
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }

            if (TableLayoutPanel1.Visible == true)
            {
                TableLayoutPanel1.Visible = false;
            }

            if (tableLayoutPanel2.Visible == true)
            {
                tableLayoutPanel2.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (label21.Visible == false)
            {
                label21.Visible = true;
            }

            if (tableLayoutPanel6.Visible == false)
            {
                tableLayoutPanel6.Visible = true;
            }
        }

        #endregion

        //Buttons
        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "Parcela";
            string raportname = "";
            if (checkBox1.Checked == true)
            {
                raportname = string.Concat("Raport ", fileName, " esantion");
            }
            else
            {
                raportname = string.Concat("Raport ", fileName);
            }
            
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;

            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("IE");
            headerRow.CreateCell(3).SetCellValue("Nr CAD");
            headerRow.CreateCell(4).SetCellValue("Nr CF");
            headerRow.CreateCell(5).SetCellValue("Nr TOPO");
            headerRow.CreateCell(6).SetCellValue("Persoana");
            headerRow.CreateCell(7).SetCellValue("Sup MAS");
            headerRow.CreateCell(8).SetCellValue("Sup ACTE");
            headerRow.CreateCell(9).SetCellValue("DIF");
            headerRow.CreateCell(10).SetCellValue("Nr TITLU");
            headerRow.CreateCell(11).SetCellValue("Nr T");
            headerRow.CreateCell(12).SetCellValue("Nr P");
            headerRow.CreateCell(13).SetCellValue("Sup P");
            headerRow.CreateCell(14).SetCellValue("CAT");
            headerRow.CreateCell(15).SetCellValue("Imprejmuit");
            headerRow.CreateCell(16).SetCellValue("Intra");
            headerRow.CreateCell(17).SetCellValue("Note Imob");
            headerRow.CreateCell(18).SetCellValue("Note Parcela");
            headerRow.CreateCell(19).SetCellValue("Note Persoana");
            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);


            //Auto Filter

            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 19));


            int rowIndex = 1;


            string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
            NumericComparer ns = new NumericComparer();
            System.Array.Sort(filez, ns);
            var files = filez.Select(x => new FileInfo(x)).ToArray();
            for (int i = 0; i < (int)files.Length; i++)
            {
                FileInfo fo = files[i];
                CGXML fisier = new CGXML();

                try
                {
                    fisier.ReadXml(fo.FullName);
                }
                catch (Exception exception)
                {
                    Exception ex = exception;
                    MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                }


                //Populate Raport
                //set vars
                //bool b = AllFileListz.Any(files[i].FullName.Contains);
                bool b = AllFileListz.Any(s => files[i].FullName.Contains(s));
                bool c = MustFileListz.Any(files[i].FullName.Contains);


                //actions
                if (checkBox1.Checked == true)
                {

                        foreach (CGXML.LandRow lr in fisier.Land)
                        {
                            cadgenno = lr.CADGENNO;
                            sector = lr.CADSECTOR;
                            ie = lr.E2IDENTIFIER;
                            measarea = lr.MEASUREDAREA.ToString();
                            if (lr.PARCELLEGALAREA == 9898989)
                            {
                            parcellegalarea = "Necompletat";
                            }
                            else
                            {
                                parcellegalarea = lr.PARCELLEGALAREA.ToString();
                            }
                            dif = (lr.PARCELLEGALAREA - lr.MEASUREDAREA).ToString();
                            note = lr.NOTES;
                            enclosed = (lr.ENCLOSED ? "DA" : "NU");
                            foreach (CGXML.PersonRow pp in fisier.Person)
                            {
                                if (pp.PERSONID == 1)
                                {
                                    persoana = string.Concat(pp.LASTNAME, " ", pp.FIRSTNAME);
                                }
                                pnotes = pp.NOTES;
                            }
                            foreach (CGXML.ParcelRow pr in fisier.Parcel)
                            {
                                nrtopo = pr.TOPONO.ToString();
                                titleno = pr.TITLENO.ToString();
                                landplotno = pr.LANDPLOTNO;
                                parcelno = pr.PARCELNO;
                                parcelarea = pr.MEASUREDAREA.ToString();
                                cat = pr.USECATEGORY;
                                intra = (pr.INTRAVILAN ? "DA" : "NU");
                                notes = pr.NOTES;
                                nrcad = pr.PAPERCADNO;
                                nrcf = pr.PAPERLBNO;
                                nrtopo = pr.TOPONO;
                            if (RandomListz.Any(fo.FullName.Contains))
                                {
                                var row = sheet.CreateRow(rowIndex);
                                row.CreateCell(0).SetCellValue(cadgenno);
                                row.CreateCell(1).SetCellValue(sector);
                                row.CreateCell(2).SetCellValue(ie);
                                row.CreateCell(3).SetCellValue(nrcad);
                                row.CreateCell(4).SetCellValue(nrcf);
                                row.CreateCell(5).SetCellValue(nrtopo);
                                row.CreateCell(6).SetCellValue(persoana);
                                row.CreateCell(7).SetCellValue(measarea);
                                row.CreateCell(8).SetCellValue(parcellegalarea);
                                row.CreateCell(9).SetCellValue(dif);
                                row.CreateCell(10).SetCellValue(titleno);
                                row.CreateCell(11).SetCellValue(landplotno);
                                row.CreateCell(12).SetCellValue(parcelno);
                                row.CreateCell(13).SetCellValue(parcelarea);
                                row.CreateCell(14).SetCellValue(cat);
                                row.CreateCell(15).SetCellValue(enclosed);
                                row.CreateCell(16).SetCellValue(intra);
                                row.CreateCell(17).SetCellValue(note);
                                row.CreateCell(18).SetCellValue(notes);
                                row.CreateCell(19).SetCellValue(pnotes);

                                rowIndex++;
                                }
                            }
                        }
                        
                }
                else
                {
                    foreach (CGXML.LandRow lr in fisier.Land)
                    {
                        cadgenno = lr.CADGENNO;
                        sector = lr.CADSECTOR;
                        ie = lr.E2IDENTIFIER;
                        measarea = lr.MEASUREDAREA.ToString();
                        if (lr.PARCELLEGALAREA == 9898989)
                        {
                            parcellegalarea = "Necompletat";
                        }
                        else
                        {
                            parcellegalarea = lr.PARCELLEGALAREA.ToString();
                        }
                        dif = (lr.PARCELLEGALAREA - lr.MEASUREDAREA).ToString();
                        note = lr.NOTES;
                        enclosed = (lr.ENCLOSED ? "DA" : "NU");

                        foreach (CGXML.PersonRow pp in fisier.Person)
                        {
                            if (pp.PERSONID == 1)
                            {
                                persoana = string.Concat(pp.LASTNAME, " ", pp.FIRSTNAME);
                            }
                            pnotes = pp.NOTES;
                        }
                        foreach (CGXML.ParcelRow pr in fisier.Parcel)
                        {
                            nrtopo = pr.TOPONO.ToString();
                            titleno = pr.TITLENO.ToString();
                            landplotno = pr.LANDPLOTNO;
                            parcelno = pr.PARCELNO;
                            parcelarea = pr.MEASUREDAREA.ToString();
                            cat = pr.USECATEGORY;
                            intra = (pr.INTRAVILAN ? "DA" : "NU");
                            notes = pr.NOTES;
                            nrcad = pr.PAPERCADNO;
                            nrcf = pr.PAPERLBNO;
                            nrtopo = pr.TOPONO;
                            
                            var row = sheet.CreateRow(rowIndex);

                            row.CreateCell(0).SetCellValue(cadgenno);
                            row.CreateCell(1).SetCellValue(sector);
                            row.CreateCell(2).SetCellValue(ie);
                            row.CreateCell(3).SetCellValue(nrcad);
                            row.CreateCell(4).SetCellValue(nrcf);
                            row.CreateCell(5).SetCellValue(nrtopo);
                            row.CreateCell(6).SetCellValue(persoana);
                            row.CreateCell(7).SetCellValue(measarea);
                            row.CreateCell(8).SetCellValue(parcellegalarea);
                            row.CreateCell(9).SetCellValue(dif);
                            row.CreateCell(10).SetCellValue(titleno);
                            row.CreateCell(11).SetCellValue(landplotno);
                            row.CreateCell(12).SetCellValue(parcelno);
                            row.CreateCell(13).SetCellValue(parcelarea);
                            row.CreateCell(14).SetCellValue(cat);
                            row.CreateCell(15).SetCellValue(enclosed);
                            row.CreateCell(16).SetCellValue(intra);
                            row.CreateCell(17).SetCellValue(note);
                            row.CreateCell(18).SetCellValue(notes);
                            row.CreateCell(19).SetCellValue(pnotes);

                            rowIndex++;
                        }
                    }

                }
            }
            //Write the stream data of workbook to the root directory

            FileStream file = new FileStream(string.Concat(CostumFolderBrowserDialogPath, "\\", raportname, " S", sector, ".xls"), FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
            //MessageBox
            DoneMsgBox msg = new DoneMsgBox();
            msg.ShowDialog();

            if (msg.DialogResult == DialogResult.No)
            {
                System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
            }
            else if (msg.DialogResult == DialogResult.Yes)
            {

                System.Diagnostics.Process.Start(CostumFolderBrowserDialogPath + "/" + raportname + " S" + sector + ".xls");
            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "Constructii";
            string raportname = "";
            if (checkBox1.Checked == true)
            {
                raportname = string.Concat("Raport ", fileName, " esantion");
            }
            else
            {
                raportname = string.Concat("Raport ", fileName);
            }
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;


            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("IE");
            headerRow.CreateCell(3).SetCellValue("Nr C");
            headerRow.CreateCell(4).SetCellValue("Sup mas");
            headerRow.CreateCell(5).SetCellValue("Destinatie");
            headerRow.CreateCell(6).SetCellValue("Acte?");
            headerRow.CreateCell(7).SetCellValue("Persoana");
            headerRow.CreateCell(8).SetCellValue("Note C");

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);



            //Auto Filter
            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 8));


            int rowIndex = 1;

                string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
                NumericComparer ns = new NumericComparer();
                System.Array.Sort(filez, ns);
                var files = filez.Select(x => new FileInfo(x)).ToArray();
                for (int i = 0; i < (int)files.Length; i++)
                {
                    FileInfo fo = files[i];
                    CGXML fisier = new CGXML();

                    try
                    {
                        fisier.ReadXml(fo.FullName);
                    }
                    catch (Exception exception)
                    {
                        Exception ex = exception;
                        MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                    }


                    //Populate Raport
                    //actions

                    if (checkBox1.Checked == true)
                    {
                            foreach (CGXML.LandRow lr in fisier.Land)
                            {
                                cadgenno = lr.CADGENNO;
                                sector = lr.CADSECTOR;
                                ie = lr.E2IDENTIFIER;
                                if (lr.BUILDINGLEGALAREA == 9898989)
                                {
                                    BLA = "Necompletat";
                                }
                                else
                                {
                                    BLA = lr.BUILDINGLEGALAREA.ToString();
                                }
                                foreach (CGXML.PersonRow pp in fisier.Person)
                                {
                                if (pp.PERSONID == 1)
                                {
                                    persoana = string.Concat(pp.LASTNAME, " ", pp.FIRSTNAME);
                                }
                                    foreach (CGXML.BuildingRow br in fisier.Building)
                                    {
                                        buildingid = br.BUILDINGID.ToString();
                                        measuredarea = br.MEASUREDAREA.ToString();
                                        destinatie = br.BUILDINGDESTINATION;
                                        legalbuilding = (br.ISLEGAL ? "DA" : "NU");
                                        bnotes = br.NOTES;
                                        nivel = br.LEVELSNO.ToString();
                                        if (br.LEGALAREA == 9898989)
                                        {
                                            legalarea = "Necompletat";
                                        }
                                        else
                                        {
                                            legalarea = br.LEGALAREA.ToString();
                                        }
                                    if (RandomListz.Any(fo.FullName.Contains))
                                    {
                                        var row = sheet.CreateRow(rowIndex);

                                        row.CreateCell(0).SetCellValue(cadgenno);
                                        row.CreateCell(1).SetCellValue(sector);
                                        row.CreateCell(2).SetCellValue(ie);
                                        row.CreateCell(3).SetCellValue(buildingid);
                                        row.CreateCell(3).SetCellValue(persoana);
                                        row.CreateCell(4).SetCellValue(legalbuilding);
                                        row.CreateCell(5).SetCellValue(measuredarea);
                                        row.CreateCell(6).SetCellValue(BLA);
                                        row.CreateCell(7).SetCellValue(legalarea);
                                        row.CreateCell(8).SetCellValue(destinatie);
                                        row.CreateCell(8).SetCellValue(nivel);
                                        row.CreateCell(8).SetCellValue(bnotes);

                                        rowIndex++;
                                    }
                                    }
                                }
                            
                            }
                        
                    }
                    else
                    {
                        foreach (CGXML.LandRow lr in fisier.Land)
                        {
                            cadgenno = lr.CADGENNO;
                            sector = lr.CADSECTOR;
                            ie = lr.E2IDENTIFIER;
                            if (lr.BUILDINGLEGALAREA == 9898989)
                            {
                                BLA = "Necompletat";
                            }
                            else
                            {
                                BLA = lr.BUILDINGLEGALAREA.ToString();
                            }

                            foreach (CGXML.PersonRow pp in fisier.Person)
                            {
                                if (pp.PERSONID == 1)
                                {
                                    persoana = string.Concat(pp.LASTNAME, " ", pp.FIRSTNAME);
                                }
                                foreach (CGXML.BuildingRow br in fisier.Building)
                                {
                                    buildingid = br.BUILDINGID.ToString();
                                    measuredarea = br.MEASUREDAREA.ToString();
                                    destinatie = br.BUILDINGDESTINATION;
                                    legalbuilding = (br.ISLEGAL ? "DA" : "NU");
                                    bnotes = br.NOTES;
                                    nivel = br.LEVELSNO.ToString();
                                    if (br.LEGALAREA == 9898989)
                                    {
                                        legalarea = "Necompletat";
                                    }
                                    else
                                    {
                                        legalarea = br.LEGALAREA.ToString();
                                    }

                                    var row = sheet.CreateRow(rowIndex);

                                    row.CreateCell(0).SetCellValue(cadgenno);
                                    row.CreateCell(1).SetCellValue(sector);
                                    row.CreateCell(2).SetCellValue(ie);
                                    row.CreateCell(3).SetCellValue(buildingid);
                                    row.CreateCell(3).SetCellValue(persoana);
                                    row.CreateCell(4).SetCellValue(legalbuilding);
                                    row.CreateCell(5).SetCellValue(measuredarea);
                                    row.CreateCell(6).SetCellValue(BLA);
                                    row.CreateCell(7).SetCellValue(legalarea);
                                    row.CreateCell(8).SetCellValue(destinatie);
                                    row.CreateCell(8).SetCellValue(nivel);
                                    row.CreateCell(8).SetCellValue(bnotes);

                                    rowIndex++;

                                }
                            }
                        }
                    }
                }

                //Write the stream data of workbook to the root directory

                FileStream file = new FileStream(string.Concat(CostumFolderBrowserDialogPath, "\\", raportname, " S", sector, ".xls"), FileMode.Create);
                hssfworkbook.Write(file);
                file.Close();
                //MessageBox
                DoneMsgBox msg = new DoneMsgBox();
                msg.ShowDialog();

                if (msg.DialogResult == DialogResult.No)
                {
                    System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
                }
                else if (msg.DialogResult == DialogResult.Yes)
                {

                    System.Diagnostics.Process.Start(CostumFolderBrowserDialogPath + "/" + raportname + " S" + sector + ".xls");
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string raportname = "Raport Sarcini";
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;


            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("IE");
            headerRow.CreateCell(3).SetCellValue("Sarcini");

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);

            //Auto Filter
            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 3));


            int rowIndex = 1;

                string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
                NumericComparer ns = new NumericComparer();
                System.Array.Sort(filez, ns);
                var files = filez.Select(x => new FileInfo(x)).ToArray();
                for (int i = 0; i < (int)files.Length; i++)
                {
                    FileInfo fo = files[i];
                    CGXML fisier = new CGXML();

                    try
                    {
                        fisier.ReadXml(fo.FullName);
                    }
                    catch (Exception exception)
                    {
                        Exception ex = exception;
                        MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                    }

                    //Populate Raport
                    //actions
                        foreach (CGXML.RegistrationRow lb in fisier.Registration)
                        {
                            if (lb.LBPARTNO != 3)
                                ;
                            else
                            {
                                lbpart = "DA";
                                foreach (CGXML.LandRow lr in fisier.Land)
                                {
                                    cadgenno = lr.CADGENNO;
                                    sector = lr.CADSECTOR;
                                    ie = lr.E2IDENTIFIER;

                                    var row = sheet.CreateRow(rowIndex);

                                    row.CreateCell(0).SetCellValue(cadgenno);
                                    row.CreateCell(1).SetCellValue(sector);
                                    row.CreateCell(2).SetCellValue(ie);
                                    row.CreateCell(3).SetCellValue(lbpart);

                                    rowIndex++;

                                }
                            }
                        }
                }
                //Write the stream data of workbook to the root directory

                FileStream file = new FileStream(string.Concat(CostumFolderBrowserDialogPath, "\\", raportname, " S", sector, ".xls"), FileMode.Create);
                hssfworkbook.Write(file);
                file.Close();
                //MessageBox
                DoneMsgBox msg = new DoneMsgBox();
                msg.ShowDialog();

                if (msg.DialogResult == DialogResult.No)
                {
                    System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
                }
                else if (msg.DialogResult == DialogResult.Yes)
                {

                    System.Diagnostics.Process.Start(CostumFolderBrowserDialogPath + "/" + raportname + " S" + sector + ".xls");
                }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileName = "Tip Inscrieri";
            string raportname = "";
            if (checkBox1.Checked == true)
            {
                raportname = string.Concat("Raport ", fileName, " esantion");
            }
            else
            {
                raportname = string.Concat("Raport ", fileName);
            }
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;


            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("IE");
            headerRow.CreateCell(3).SetCellValue("Sup");
            headerRow.CreateCell(4).SetCellValue("Tip Inscriere");
            headerRow.CreateCell(5).SetCellValue("Nr");
            headerRow.CreateCell(6).SetCellValue("Data");
            headerRow.CreateCell(7).SetCellValue("Tip Act");
            headerRow.CreateCell(8).SetCellValue("Emitent");
            headerRow.CreateCell(9).SetCellValue("Note Inscriere");
            headerRow.CreateCell(10).SetCellValue("Note Acte");

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);

            //Auto Filter

            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 8));


            int rowIndex = 1;

                string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
                NumericComparer ns = new NumericComparer();
                System.Array.Sort(filez, ns);
                var files = filez.Select(x => new FileInfo(x)).ToArray();
                for (int i = 0; i < (int)files.Length; i++)
                {
                    FileInfo fo = files[i];
                    CGXML fisier = new CGXML();

                    try
                    {
                        fisier.ReadXml(fo.FullName);
                    }
                    catch (Exception exception)
                    {
                        Exception ex = exception;
                        MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                    }


                    //Populate Raport
                    //actions
                    if (checkBox1.Checked == true)
                    {
                        foreach (CGXML.LandRow lr in fisier.Land)
                        {
                            cadgenno = lr.CADGENNO;
                            sector = lr.CADSECTOR;
                            sup = lr.MEASUREDAREA.ToString();
                            ie = lr.E2IDENTIFIER;
                        }
                            foreach (CGXML.RegistrationRow lb in fisier.Registration)
                            {
                                if (lb.REGISTRATIONTYPE == "NOTATION")
                                {
                                    regtype = "Notare";
                                }
                                if (lb.REGISTRATIONTYPE == "POSESION_REGISTATION")
                                {
                                    regtype = "Inscrierea posesiei";
                                }
                                if (lb.REGISTRATIONTYPE == "PROVISIONALENTRY")
                                {
                                    regtype = "Inscrierea provizorie";
                                }
                                if (lb.REGISTRATIONTYPE == "INTAB")
                                {
                                    regtype = "Intabulare";
                                }
                            string regnotes = lb.COMMENTS;

                                foreach (CGXML.DeedRow lm in fisier.Deed)
                                {
                                    string deed = lm.DEEDNUMBER;
                                    string deeddate = lm.DEEDDATE.ToString();
                                    string deednote = lm.NOTES;
                                    if(lm.DEEDTYPE == "ACT_NOTARIAL")
                                    {
                                    deedtype = "Act Notarial";
                                    }
                                    if (lm.DEEDTYPE == "ADMINISTRATIVE_1")
                                    {
                                        deedtype = "Act Administrativ";
                                    }
                                    else
                                {
                                    deedtype = lm.DEEDTYPE;
                                }
                                    
                                string deedautority = lm.AUTHORITY;

                                if (RandomListz.Any(fo.FullName.Contains))
                                {
                                    var row = sheet.CreateRow(rowIndex);

                                    row.CreateCell(0).SetCellValue(cadgenno);
                                    row.CreateCell(1).SetCellValue(sector);
                                    row.CreateCell(2).SetCellValue(ie);
                                    row.CreateCell(3).SetCellValue(sup);
                                    row.CreateCell(4).SetCellValue(regtype);
                                    row.CreateCell(5).SetCellValue(deed);
                                    row.CreateCell(6).SetCellValue(deeddate);
                                    row.CreateCell(7).SetCellValue(deedtype);
                                    row.CreateCell(8).SetCellValue(deedautority);
                                    row.CreateCell(9).SetCellValue(regnotes);
                                    row.CreateCell(10).SetCellValue(deednote);

                                    rowIndex++;
                                }
                                }
                            }
                        
                    }
                    else
                    {
                        foreach (CGXML.LandRow lr in fisier.Land)
                        {
                            cadgenno = lr.CADGENNO;
                            sector = lr.CADSECTOR;
                            sup = lr.MEASUREDAREA.ToString();
                            ie = lr.E2IDENTIFIER;
                        }
                        foreach (CGXML.RegistrationRow lb in fisier.Registration)
                        {
                            if (lb.REGISTRATIONTYPE == "NOTATION")
                            {
                                regtype = "Notare";
                            }
                            if (lb.REGISTRATIONTYPE == "POSESION_REGISTATION")
                            {
                                regtype = "Inscrierea posesiei";
                            }
                            if (lb.REGISTRATIONTYPE == "PROVISIONALENTRY")
                            {
                                regtype = "Inscrierea provizorie";
                            }
                            if (lb.REGISTRATIONTYPE == "INTAB")
                            {
                                regtype = "Intabulare";
                            }
                            string regnotes = lb.COMMENTS;

                            foreach (CGXML.DeedRow lm in fisier.Deed)
                            {
                                string deed = lm.DEEDNUMBER;
                                string deeddate = lm.DEEDDATE.ToString();
                                string deednote = lm.NOTES;
                                if (lm.DEEDTYPE == "ACT_NOTARIAL")
                                {
                                    deedtype = "Act Notarial";
                                }
                                if (lm.DEEDTYPE == "ADMINISTRATIVE_1")
                                {
                                    deedtype = "Act Administrativ";
                                }
                                else
                                {
                                    deedtype = lm.DEEDTYPE;
                                }

                                string deedautority = lm.AUTHORITY;

                                var row = sheet.CreateRow(rowIndex);

                                row.CreateCell(0).SetCellValue(cadgenno);
                                row.CreateCell(1).SetCellValue(sector);
                                row.CreateCell(2).SetCellValue(ie);
                                row.CreateCell(3).SetCellValue(sup);
                                row.CreateCell(4).SetCellValue(regtype);
                                row.CreateCell(5).SetCellValue(deed);
                                row.CreateCell(6).SetCellValue(deeddate);
                                row.CreateCell(7).SetCellValue(deedtype);
                                row.CreateCell(8).SetCellValue(deedautority);
                                row.CreateCell(9).SetCellValue(regnotes);
                                row.CreateCell(10).SetCellValue(deednote);

                                rowIndex++;

                            }
                        }
                    }
                }
                //Write the stream data of workbook to the root directory

                FileStream file = new FileStream(string.Concat(CostumFolderBrowserDialogPath, "\\", raportname, " S", sector, ".xls"), FileMode.Create);
                hssfworkbook.Write(file);
                file.Close();
                //MessageBox
                DoneMsgBox msg = new DoneMsgBox();
                msg.ShowDialog();

                if (msg.DialogResult == DialogResult.No)
                {
                    System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
                }
                else if (msg.DialogResult == DialogResult.Yes)
                {

                    System.Diagnostics.Process.Start(CostumFolderBrowserDialogPath + "/" + raportname + " S" + sector + ".xls");
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fileName = "Persoana";
            string raportname = "";
            if (checkBox1.Checked == true)
            {
                raportname = string.Concat("Raport ", fileName, " esantion");
            }
            else
            {
                raportname = string.Concat("Raport ", fileName);
            }
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;


            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("Persoana");
            headerRow.CreateCell(3).SetCellValue("CNP/CUI");
            headerRow.CreateCell(4).SetCellValue("Defunct");
            headerRow.CreateCell(5).SetCellValue("Adresa");
            headerRow.CreateCell(6).SetCellValue("Note");

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);



            //Auto Filter
            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 6));


            int rowIndex = 1;
            DataSet dsUAT = new DataSet();
            DataSet dsLocality = new DataSet();
            DataSet dsStreetType = new DataSet();
            dsUAT.ReadXml(string.Concat(Application.StartupPath.ToString(), "\\ProgramData\\Admin.xml"));
            dsLocality.ReadXml(string.Concat(Application.StartupPath.ToString(), "\\ProgramData\\Locality.xml"));
            dsStreetType.ReadXml(string.Concat(Application.StartupPath.ToString(), "\\ProgramData\\Dictionary.xml"));

            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML'uri";

                string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
                NumericComparer ns = new NumericComparer();
                System.Array.Sort(filez, ns);
                var files = filez.Select(x => new FileInfo(x)).ToArray();
                for (int i = 0; i < (int)files.Length; i++)
                {
                    FileInfo fo = files[i];
                    CGXML fisier = new CGXML();

                    try
                    {
                        fisier.ReadXml(fo.FullName);
                    }
                    catch (Exception exception)
                    {
                        Exception ex = exception;
                        MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                    }

                
                    //Populate Raport
                    //set vars

                    //actions
                    if (checkBox1.Checked == true)
                    {
                        foreach (CGXML.LandRow lr in fisier.Land)
                        {
                            cadgenno = lr.CADGENNO;
                            DataTable item = fisier.Tables["ADDRESS"];
                            int aDDRESSID = lr.ADDRESSID;
                            DataRow[] drAddress = item.Select(string.Concat("ADDRESSID=", aDDRESSID.ToString()));
                            UAT_land = dsUAT.Tables[0].Select(string.Concat("ADMINISTRATIVEUNITID='", drAddress[0][1], "'"))[0][2].ToString();
                            UAT_land = UAT_land.Normalize(NormalizationForm.FormD);
                            sector = lr.CADSECTOR;
                        }
                            foreach (CGXML.PersonRow pr in fisier.Person)
                            {
                                persoana = string.Concat(pr.LASTNAME, " ", pr.FIRSTNAME);
                                persoana = persoana.Replace("|", "");
                                defunct = (pr.DEFUNCT ? "DA" : "NU");
                                note = pr.NOTES;
                                cnp = pr.IDCODE;
                                int addressid = pr.ADDRESSID;
                                DataRow[] drAddress = fisier.Tables["ADDRESS"].Select(string.Concat("ADDRESSID=", addressid.ToString()));
                                if (!string.IsNullOrEmpty(drAddress[0][1].ToString()))
                                {
                                    try
                                    {
                                        DataRow[] drUAT = dsUAT.Tables[0].Select(string.Concat("ADMINISTRATIVEUNITID='", drAddress[0][1], "'"));
                                        adresa = string.Concat("UAT ", drUAT[0][2]);
                                        if (drAddress[0][3].ToString().ToLower() == "true")
                                        {
                                            DataRow[] drLocality = dsLocality.Tables[0].Select(string.Concat("LOCALITYID='", drAddress[0][2], "'"));
                                            adresa = string.Concat(new object[] { adresa, ", Loc. ", drLocality[0][2], ", " });
                                            if (fisier.Tables["ADDRESS"].Columns.Contains("DISTRICTTYPE") && !string.IsNullOrEmpty(drAddress[0][4].ToString()))
                                            {
                                                DataRow[] drDict = dsStreetType.Tables[0].Select(string.Concat("DICTIONARYITEMCODE='", drAddress[0]["DISTRICTTYPE"], "' AND DICTIONARYCODE='DISTRICT'"));
                                                adresa = string.Concat(new object[] { adresa, drDict[0][3], " ", drAddress[0][5] });
                                            }
                                            if (fisier.Tables["ADDRESS"].Columns.Contains("STREETTYPE") && !string.IsNullOrEmpty(drAddress[0][6].ToString()))
                                            {
                                                DataRow[] drDict = dsStreetType.Tables[0].Select(string.Concat("DICTIONARYITEMCODE='", drAddress[0]["STREETTYPE"], "' AND DICTIONARYCODE='ST'"));
                                                adresa = string.Concat(new object[] { adresa, ", ", drDict[0][3], " ", drAddress[0][7] });
                                            }
                                            if (fisier.Tables["ADDRESS"].Columns.Contains("POSTALNUMBER") && !string.IsNullOrEmpty(drAddress[0][8].ToString()))
                                            {
                                                adresa = string.Concat(adresa, ", Nr. ", drAddress[0][8]);
                                            }
                                            if (fisier.Tables["ADDRESS"].Columns.Contains("BLOCK") && !string.IsNullOrEmpty(drAddress[0][9].ToString()))
                                            {
                                                adresa = string.Concat(adresa, ", Bloc ", drAddress[0][9]);
                                            }
                                            if (fisier.Tables["ADDRESS"].Columns.Contains("ENTRY") && !string.IsNullOrEmpty(drAddress[0][10].ToString()))
                                            {
                                                adresa = string.Concat(adresa, ", Sc. ", drAddress[0][10]);
                                            }
                                            if (fisier.Tables["ADDRESS"].Columns.Contains("FLOOR") && !string.IsNullOrEmpty(drAddress[0][11].ToString()))
                                            {
                                                adresa = string.Concat(adresa, ", Et. ", drAddress[0][11]);
                                            }
                                            if (fisier.Tables["ADDRESS"].Columns.Contains("APNO") && !string.IsNullOrEmpty(drAddress[0][12].ToString()))
                                            {
                                                adresa = string.Concat(adresa, ", Ap. ", drAddress[0][12]);
                                            }
                                            if (fisier.Tables["ADDRESS"].Columns.Contains("ZIPCODE") && !string.IsNullOrEmpty(drAddress[0][13].ToString()))
                                            {
                                                adresa = string.Concat(adresa, ", Cod postal ", drAddress[0][13]);
                                            }
                                        }
                                    }
                                    catch (Exception exception1)
                                    {
                                        MessageBox.Show(string.Concat(cadgenno, " cu probleme"));
                                    }
                                }
                                else
                                {
                                    adresa = "In afara tarii";
                                }
                                if (RandomListz.Any(fo.FullName.Contains))
                                {
                                    var row = sheet.CreateRow(rowIndex);

                                    row.CreateCell(0).SetCellValue(cadgenno);
                                    row.CreateCell(1).SetCellValue(sector);
                                    row.CreateCell(2).SetCellValue(persoana);
                                    row.CreateCell(3).SetCellValue(cnp);
                                    row.CreateCell(4).SetCellValue(defunct);
                                    row.CreateCell(5).SetCellValue(adresa);
                                    row.CreateCell(6).SetCellValue(note);

                                    rowIndex++;
                                }
                            }
                    }
                    else
                    {
                        foreach (CGXML.LandRow lr in fisier.Land)
                        {
                            cadgenno = lr.CADGENNO;
                            DataTable item = fisier.Tables["ADDRESS"];
                            int aDDRESSID = lr.ADDRESSID;
                            DataRow[] drAddress = item.Select(string.Concat("ADDRESSID=", aDDRESSID.ToString()));
                            UAT_land = dsUAT.Tables[0].Select(string.Concat("ADMINISTRATIVEUNITID='", drAddress[0][1], "'"))[0][2].ToString();
                            UAT_land = UAT_land.Normalize(NormalizationForm.FormD);
                            sector = lr.CADSECTOR;
                        }
                        foreach (CGXML.PersonRow pr in fisier.Person)
                        {
                            persoana = string.Concat(pr.LASTNAME, " ", pr.FIRSTNAME);
                            persoana = persoana.Replace("|", "");
                            defunct = (pr.DEFUNCT ? "DA" : "NU");
                            note = pr.NOTES;
                            cnp = pr.IDCODE;
                            int addressid = pr.ADDRESSID;
                            DataRow[] drAddress = fisier.Tables["ADDRESS"].Select(string.Concat("ADDRESSID=", addressid.ToString()));
                            if (!string.IsNullOrEmpty(drAddress[0][1].ToString()))
                            {
                                try
                                {
                                    DataRow[] drUAT = dsUAT.Tables[0].Select(string.Concat("ADMINISTRATIVEUNITID='", drAddress[0][1], "'"));
                                    adresa = string.Concat("UAT ", drUAT[0][2]);
                                    if (drAddress[0][3].ToString().ToLower() == "true")
                                    {
                                        DataRow[] drLocality = dsLocality.Tables[0].Select(string.Concat("LOCALITYID='", drAddress[0][2], "'"));
                                        adresa = string.Concat(new object[] { adresa, ", Loc. ", drLocality[0][2], ", " });
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("DISTRICTTYPE") && !string.IsNullOrEmpty(drAddress[0][4].ToString()))
                                        {
                                            DataRow[] drDict = dsStreetType.Tables[0].Select(string.Concat("DICTIONARYITEMCODE='", drAddress[0]["DISTRICTTYPE"], "' AND DICTIONARYCODE='DISTRICT'"));
                                            adresa = string.Concat(new object[] { adresa, drDict[0][3], " ", drAddress[0][5] });
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("STREETTYPE") && !string.IsNullOrEmpty(drAddress[0][6].ToString()))
                                        {
                                            DataRow[] drDict = dsStreetType.Tables[0].Select(string.Concat("DICTIONARYITEMCODE='", drAddress[0]["STREETTYPE"], "' AND DICTIONARYCODE='ST'"));
                                            adresa = string.Concat(new object[] { adresa, ", ", drDict[0][3], " ", drAddress[0][7] });
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("POSTALNUMBER") && !string.IsNullOrEmpty(drAddress[0][8].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Nr. ", drAddress[0][8]);
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("BLOCK") && !string.IsNullOrEmpty(drAddress[0][9].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Bloc ", drAddress[0][9]);
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("ENTRY") && !string.IsNullOrEmpty(drAddress[0][10].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Sc. ", drAddress[0][10]);
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("FLOOR") && !string.IsNullOrEmpty(drAddress[0][11].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Et. ", drAddress[0][11]);
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("APNO") && !string.IsNullOrEmpty(drAddress[0][12].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Ap. ", drAddress[0][12]);
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("ZIPCODE") && !string.IsNullOrEmpty(drAddress[0][13].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Cod postal ", drAddress[0][13]);
                                        }
                                    }
                                }
                                catch (Exception exception1)
                                {
                                    MessageBox.Show(string.Concat(cadgenno, " cu probleme"));
                                }
                            }
                            else
                            {
                                adresa = "In afara tarii";
                            }
                            var row = sheet.CreateRow(rowIndex);

                            row.CreateCell(0).SetCellValue(cadgenno);
                            row.CreateCell(1).SetCellValue(sector);
                            row.CreateCell(2).SetCellValue(persoana);
                            row.CreateCell(3).SetCellValue(cnp);
                            row.CreateCell(4).SetCellValue(defunct);
                            row.CreateCell(5).SetCellValue(adresa);
                            row.CreateCell(6).SetCellValue(note);

                            rowIndex++;

                        }
                    }
                }
                //Write the stream data of workbook to the root directory

                FileStream file = new FileStream(string.Concat(CostumFolderBrowserDialogPath, "\\", raportname, " S", sector, ".xls"), FileMode.Create);
                hssfworkbook.Write(file);
                file.Close();
                //MessageBox
                DoneMsgBox msg = new DoneMsgBox();
                msg.ShowDialog();

                if (msg.DialogResult == DialogResult.No)
                {
                    System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
                }
                else if (msg.DialogResult == DialogResult.Yes)
                {

                    System.Diagnostics.Process.Start(CostumFolderBrowserDialogPath + "/" + raportname + " S" + sector + ".xls");
                }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            RandomListz.Clear();
            AllFileListz.Clear();
            MustFileListz.Clear();
            string raportname = "Lista ID de verificat";
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;


            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("IE");
            headerRow.CreateCell(3).SetCellValue("Tip ID");

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);



            //Auto Filter
            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 3));


            int rowIndex = 1;
            Random r = new Random();

            //

                string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
                NumericComparer ns = new NumericComparer();
                System.Array.Sort(filez, ns);
                var files = filez.Select(x => new FileInfo(x)).ToArray();
                for (int i = 0; i < (int)files.Length; i++)
                {
                    FileInfo fo = files[i];
                    CGXML fisier = new CGXML();

                    try
                    {
                        fisier.ReadXml(fo.FullName);
                    }
                    catch (Exception exception)
                    {
                        Exception ex = exception;
                        MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                    }


                    AllFileListz.Add(files[i].FullName);

                    //Populate Raport
                    //set vars
                    string test = "10";

                    //actions
                    
                    foreach (CGXML.LandRow lr in fisier.Land)
                    {
                        cadgenno = lr.CADGENNO;
                        sector = lr.CADSECTOR;
                        ie = lr.E2IDENTIFIER;
                        bool a = TempFileListz.Any(fo.FullName.Contains);
                        bool b = TempFileListz.Contains(fo.FullName);
                        bool c = (TempFileListz.Where(o => string.Equals(fo.FullName, o, StringComparison.OrdinalIgnoreCase)).Any());

                            foreach (CGXML.RegistrationRow lb in fisier.Registration)
                            {
                                if (lb.LBPARTNO == 3)
                                {
                                    lbpart = "Sarcini";
                                    
                                if (!TempFileListz.Any(fo.FullName.Contains))
                                {
                                    var row = sheet.CreateRow(rowIndex);
                                    row.CreateCell(0).SetCellValue(cadgenno);
                                    row.CreateCell(1).SetCellValue(sector);
                                    row.CreateCell(2).SetCellValue(ie);
                                    row.CreateCell(3).SetCellValue(lbpart);
                                    TempFileListz.Add(fo.FullName);
                                    MustFileListz.Add(fo.FullName);
                                    RandomListz.Add(fo.FullName);
                                    rowIndex++;

                                }
                            }
                        }
                    }


                }
                AllFileListz.RemoveAll(item => MustFileListz.Contains(item));
                double roundfilescount = Math.Round(AllFileListz.Count / 10.0);
                //adauga 1 daca valoarea este mai mare de ".0"
                //(FileListSet.Count / 10) + (FileListSet.Count % procent > 0 ? 1 : 0)

                int files2random = Convert.ToInt32(roundfilescount);
                Random = AllFileListz.OrderBy(x => r.Next()).Take(files2random);

                //second part
                //de reparat pt fiecare obiect dint random nu din filelistsets
                //for (int k = 0; k < (int)FileListSet.Count; k++)
                foreach (var RandomVar in Random)
                {

                    CGXML fisier = new CGXML();

                    try
                    {
                        fisier.ReadXml(RandomVar);
                    }
                    catch (Exception exception)
                    {
                        Exception ex = exception;
                        MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, RandomVar }));
                    }


                    //Populate Raport
                    //set vars
                    int nr = 0;

                    foreach (CGXML.LandRow ffs in fisier.Land)
                    {
                        cadgenno = (ffs.CADGENNO);
                        sector = ffs.CADSECTOR;
                        ie = ffs.E2IDENTIFIER;
                        var row = sheet.CreateRow(rowIndex);

                        row.CreateCell(0).SetCellValue(cadgenno);
                        row.CreateCell(1).SetCellValue(sector);
                        row.CreateCell(2).SetCellValue(ie);
                        row.CreateCell(3).SetCellValue(lbpart);
                        RandomListz.Add(RandomVar);
                        rowIndex++;
                    }
                }

                //Write the stream data of workbook to the root directory

                FileStream file = new FileStream(string.Concat(CostumFolderBrowserDialogPath, "\\", raportname, " S", sector, ".xls"), FileMode.Create);
                hssfworkbook.Write(file);
                file.Close();
                //MessageBox
                DoneMsgBox msg = new DoneMsgBox();
                msg.ShowDialog();

                if (msg.DialogResult == DialogResult.No)
                {
                    System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
                }
                else if (msg.DialogResult == DialogResult.Yes)
                {

                    System.Diagnostics.Process.Start(CostumFolderBrowserDialogPath + "/" + raportname + " S" + sector + ".xls");
                }
                
                if (checkBox1.Visible != true)
                { checkBox1.Visible = true; }
                
                TempFileListz.Clear();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Visible == true)
            {
                this.checkBox1.Visible = false;
            }
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML'uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                tEnabled(true);
                CostumFolderBrowserDialogPath = CostumFolderBrowserDialog.SelectedPath;
            }
        }

        #endregion

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                checkBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //browse
            FileInfo[] files = (new DirectoryInfo(CostumFolderBrowserDialogPath)).GetFiles("*.cgxml", SearchOption.AllDirectories);       
            //initial vars
            string shapefile = string.Concat(CostumFolderBrowserDialogPath, "\\", "Imobile");
            string futureFieldName = "ID";
            string futureFieldAreaCG = "Suprafata";
            string futureFieldLegalCG = "Suprafata Acte";
            string futurePerson = "Persoana";
            int nrCGXML = 0;
            for (int i = 0; i < (int)files.Length; i++)
            {
                nrCGXML++;
            }
            
            Feature[] poop = new Feature[nrCGXML];
            //loop trough cgxml
            for (int i = 0; i < (int)files.Length; i++)
            {
                    FileInfo fo = files[i];
                    CGXML fisier = new CGXML();
                    try
                    {
                        fisier.ReadXml(fo.FullName);
                    }
                    catch (Exception exception)
                    {
                        Exception ex = exception;
                        MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                    }

                //create geometry factory
                IGeometryFactory geomFactory = NtsGeometryServices.Instance.CreateGeometryFactory();
                foreach (CGXML.LandRow lr in fisier.Land)
                {
                    var r = 0;
                    string Person = "";
                    Coordinate[] myCoord = new Coordinate[fisier.Points.Count];
                    foreach (CGXML.PointsRow pr in fisier.Points)
                    {
                        myCoord[r] = new Coordinate(pr.X, pr.Y);
                        r++;
                    }
                    foreach(CGXML.PersonRow pp in fisier.Person)
                    {
                        if(pp.PERSONID == 1)
                        {
                            Person = string.Concat(pp.FIRSTNAME, " ", pp.LASTNAME);
                        }
                    }
                    if (myCoord[0] != myCoord.Last())
                    {
                        myCoord[i++] = myCoord[0];
                    }
                    //create the default table with fields - alternately use DBaseField classes
                    AttributesTable t = new AttributesTable();
                    t.AddAttribute(futureFieldName, lr.CADGENNO);
                    t.AddAttribute(futureFieldAreaCG, lr.MEASUREDAREA);
                    t.AddAttribute(futureFieldLegalCG , lr.PARCELLEGALAREA);
                    t.AddAttribute(futurePerson, Person);
                    //Geometry 
                    if (myCoord[0] != myCoord.Last())
                    {
                        myCoord[i++] = myCoord[0];
                    }
                    IGeometry g = geomFactory.CreatePolygon(myCoord);
                    var x = 0;
                    poop[x] = new Feature(g, t);
                    x++;
                }
            }
            //Feature list
            IList<Feature> features = poop.OfType<Feature>().ToList();
            ShapefileDataWriter writer = new ShapefileDataWriter(shapefile) { Header = ShapefileDataWriter.GetHeader(features[0], features.Count) };
            writer.Write(features);

            System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fileName = "Puncte";
            string raportname = "";
            if (checkBox1.Checked == true)
            {
                raportname = string.Concat("Raport ", fileName, " esantion");
            }
            else
            {
                raportname = string.Concat("Raport ", fileName);
            }

            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;

            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("X");
            headerRow.CreateCell(1).SetCellValue("Y");
            headerRow.CreateCell(2).SetCellValue("Nr Pct");
            headerRow.CreateCell(3).SetCellValue("ID");
            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);
            
            //Auto Filter

            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 19));

            int rowIndex = 1;

            FileInfo[] files = (new DirectoryInfo(CostumFolderBrowserDialogPath)).GetFiles("*.cgxml", SearchOption.AllDirectories);
            for (int i = 0; i < (int)files.Length; i++)
            {
                FileInfo fo = files[i];
                CGXML fisier = new CGXML();

                try
                {
                    fisier.ReadXml(fo.FullName);
                }
                catch (Exception exception)
                {
                    Exception ex = exception;
                    MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                }
                //actions
                foreach (CGXML.LandRow lr in fisier.Land)
                {
                    int ID = Int32.Parse(lr.CADGENNO);
                    foreach (CGXML.PointsRow pr in fisier.Points)
                    {
                        var row = sheet.CreateRow(rowIndex);
                        row.CreateCell(0).SetCellValue(pr.X);
                        row.CreateCell(1).SetCellValue(pr.Y);
                        row.CreateCell(2).SetCellValue(pr.POINTID);
                        row.CreateCell(3).SetCellValue(ID);

                        rowIndex++;
                    }
                }
            }
            //Write the stream data of workbook to the root directory

            FileStream file = new FileStream(string.Concat(CostumFolderBrowserDialogPath, "\\", raportname, " S", sector, ".xls"), FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
            //MessageBox
            DoneMsgBox msg = new DoneMsgBox();
            msg.ShowDialog();

            if (msg.DialogResult == DialogResult.No)
            {
                System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
            }
            else if (msg.DialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(CostumFolderBrowserDialogPath + "/" + raportname + " S" + sector + ".xls");
            }

        }
    }
}
