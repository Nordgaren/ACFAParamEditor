﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using SoulsFormats;

namespace ACFAParamEditor
{
    public partial class MainForm : Form
    {
        // Initialize global def list
        private List<PARAMDEF> defList = new List<PARAMDEF>();
        public MainForm()
        {
            InitializeComponent();
        }

        // On Main Form Load, add the defs to the global def list
        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.createLog();
            Directory.CreateDirectory($"{Util.resFolderPath}/def/");

            // Use override to change colors of selected Menu Strip items to dark mode and disable shadows
            MainFormMenuStrip.Renderer = new ToolStripProfessionalRenderer(new OverrideMenuStripSelectedColorTable());
            FileMS.DropDown.DropShadowEnabled = false;
            ConvertMS.DropDown.DropShadowEnabled = false;
            RowMS.DropDown.DropShadowEnabled = false;
            HelpMS.DropDown.DropShadowEnabled = false;

            // Create def list on form load
            string[] defFiles = Directory.GetFiles($"{Util.resFolderPath}/def/", "*.def");      // Switch xml/def to test either
            foreach (string defPath in defFiles)
            {
                try
                {
                    defList.Add(PARAMDEF.Read(defPath));                            // Comment/Uncomment this line to test Def
                    //defList.Add(PARAMDEF.XmlDeserialize(defPath));                // Comment/Uncomment this line to test xml
                }
                catch (InvalidDataException IDEx)
                {
                    string description = $"Failed to parse Paramdef at {defPath}";
                    TSSLDefReading.Text = $"DEBUG: {description}, see parameditor.log";
                    Debug.WriteLine($"{description}");
                    Logger.LogExceptionWithDate(IDEx, description);
                }
            }

            // If the def resource folder is empty for some reason
            if (defList.Count == 0)
            {
                OpenParamsFMS.Enabled = false;
                string description = "WARNING: No defs found in resource folder";
                TSSLDefReading.Text = description;
                Debug.WriteLine(description);
                Logger.LogErrorWithDate(description);
            }
        }

        #region MenuItems
        // Open Params
        private void OpenParamsFMS_click(object sender, EventArgs e)
        {
            // Prompt the user for folders containing param files
            CommonOpenFileDialog binFolderPathDialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true,
                Title = "Select the Folder containing your Params"
            };

            if (binFolderPathDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            var binFolderPath = binFolderPathDialog.FileName;

            // Apply defs to params
            ParamDGV.Rows.Clear();
            string[] binFiles = Directory.GetFiles(binFolderPath, "*.*");
            foreach (string binPath in binFiles)
            {
                try
                {
                    try
                    {
                        var param = new ParamWrapper()
                        {
                            ParamName = Path.GetFileNameWithoutExtension(binPath),
                            Param = PARAM.Read(binPath)
                        };

                        var applyDef = param.Param.ApplyParamdefCarefully(defList);
                        if (applyDef == true)
                        {
                            object[] newParamRow = { param, $"{param.Param.ParamType}" };
                            ParamDGV.Rows.Add(newParamRow);
                        }
                    }
                    catch (EndOfStreamException EOSe)
                    {
                        string description = $"Failed to parse Param at {binPath}";
                        TSSLParamReading.Text = $"DEBUG: {description}, see parameditor.log";
                        Debug.WriteLine($"{description}");
                        Logger.LogExceptionWithDate(EOSe, description);
                    }
                }
                catch (InvalidDataException IDEx)
                {
                    string description = $"Failed to parse Param at {binPath}";
                    TSSLParamReading.Text = $"DEBUG: {description}, see parameditor.log";
                    Debug.WriteLine($"{description}");
                    Logger.LogExceptionWithDate(IDEx, description);
                }
            }  
        }

        // TODO: Save the user's changes to params when they press save
        private void SaveFMS_Click(object sender, EventArgs e)
        {

        }

        // Convert defs to xmls - Does not convert properly yet and leads to more null cells
        // TODO: Fix def to xml conversion
        private void ConvertDefXmlCMS_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory($"{Util.resFolderPath}/xml/");

            // Prompt the user for folders containing def files to be serialized into Paramdef Xmls
            CommonOpenFileDialog defFolderPathDialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true,
                Title = "Select the Folder containing your Defs to convert them into XMLs"
            };

            if (defFolderPathDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            // Convert defs to xmls
            var defUserFolderPath = defFolderPathDialog.FileName;
            string[] defFiles = Directory.GetFiles(defUserFolderPath, "*.*");
            foreach (string defPath in defFiles)
            {
                try
                {
                    PARAMDEF paramdef = PARAMDEF.Read(defPath);
                    paramdef.XmlSerialize($"{Util.resFolderPath}/xml/{Path.GetFileNameWithoutExtension(defPath)}.xml");
                }
                catch (InvalidDataException IDEx)
                {
                    ReaderStatusStrip.Items.Clear();
                    string description = $"Failed to serialize file into Paramdef Xml at {defPath}";
                    TSSLDefReading.Text = $"DEBUG: {description}, see parameditor.log";
                    Debug.WriteLine($"{description}");
                    Logger.LogExceptionWithDate(IDEx, description);
                }
            }
        }

        // TODO: Convert Params to CSVs
        private void ConvertParamCSVCMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Convert CSVs to Params
        private void ConvertCSVParamCMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Convert Params to TSVs
        private void ConvertParamTSVCMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Convert TSVs to Params
        private void ConvertTSVParamCMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Copy the currently selected row
        private void CopyRowRMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Delete the currently selected row
        private void DeleteRowRMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Show About form message
        private void AboutHMS_Click(object sender, EventArgs e)
        {

        }
        #endregion MenuItems

        #region DataGridViewSelectionChanges
        // Show newly selected Param's Rows when Param DataGridView selection changes
        // TODO: Save added rows and potentially have to make sure row state is saved
        private void ParamDGV_SelectionChanged(object sender, EventArgs e)
        {
            RowDGV.Rows.Clear();
            CellDGV.Rows.Clear();    
            var selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;

            foreach (var row in selectedParam.Param.Rows)
            {
                var rowWrapper = new RowWrapper()
                {      
                    Row = row
                };

                object[] newRow = {rowWrapper.Row.ID, rowWrapper};
                RowDGV.Rows.Add(newRow);
            }
        }

        // Show newly selected Row's Cells when Row DataGridView selection changes
        // TODO: Potentially have to make sure cell states are saved
        private void RowDGV_SelectionChanged(object sender, EventArgs e)
        {
            CellDGV.Rows.Clear();
            var selectedRow = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
            if (selectedRow.Row.Cells != null)
            {
                foreach (var cell in selectedRow.Row.Cells)
                {
                    string[] newCellRow = { $"{cell.Def.DisplayType}", $"{cell.Def.DisplayName}", $"{cell.Value}" };
                    CellDGV.Rows.Add(newCellRow);
                }
            }
            else 
            {
                ReaderStatusStrip.Items.Clear();
                string description = $"Row {selectedRow.Row.ID} in {ParamDGV.CurrentRow.Cells[0].Value} has Null Cells";
                TSSLCellReading.Text = description;
                Logger.LogErrorWithDate(description);
                return;
            }        
        }
        #endregion DataGridViewSelectionChanges

        #region DataGridViewSaveState
        // TODO: Save a row's state when the DataGridView cell's value changes
        private void RowDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        // TODO: Save a cell's state when a DataGridView cell's value changes
        private void CellDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion DataGridViewSaveState

        // TODO: When someone attempts to drag a file into the window's Param viewing area
        private void SplitContainerA_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        // TODO: Check the dropped item
        private void SplitContainerA_DragDrop(object sender, DragEventArgs e)
        {

        }

        
    }
}
