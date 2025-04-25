/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2013 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

namespace OpenHardwareMonitor.GUI {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sensor = new Aga.Controls.Tree.TreeColumn();
            value = new Aga.Controls.Tree.TreeColumn();
            min = new Aga.Controls.Tree.TreeColumn();
            max = new Aga.Controls.Tree.TreeColumn();
            nodeImage = new Aga.Controls.Tree.NodeControls.NodeIcon();
            nodeCheckBox = new Aga.Controls.Tree.NodeControls.NodeCheckBox();
            nodeTextBoxText = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            nodeTextBoxValue = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            nodeTextBoxMin = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            nodeTextBoxMax = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            mainMenu = new System.Windows.Forms.MenuStrip();
            fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            resetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            mainboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cpuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gpuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fanControllerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hddMenuItemRemovable = new System.Windows.Forms.ToolStripMenuItem();
            networkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuItem6 = new System.Windows.Forms.ToolStripSeparator();
            exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            resetMinMaxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            hiddenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            plotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gadgetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            columnsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            valueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            maxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            startMinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            minTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            minCloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            startupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            runAsServiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showGadgetWindowTopmostMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            separatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
            temperatureUnitsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            celsiusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fahrenheitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            plotLocationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            plotWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            plotBottomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            plotRightMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            logSeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
            logSensorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loggingIntervalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log1sMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log2sMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log5sMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log10sMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log30sMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log1minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log2minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log5minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log10minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log30minMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log1hMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log2hMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            log6hMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            webMenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            webMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            runWebServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            allowRemoteAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            serverPortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            treeContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            timer = new System.Windows.Forms.Timer(components);
            splitContainer = new SplitContainerAdv();
            treeView = new Aga.Controls.Tree.TreeViewAdv();
            mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // sensor
            // 
            sensor.Header = "Sensor";
            sensor.SortOrder = System.Windows.Forms.SortOrder.None;
            sensor.TooltipText = null;
            // 
            // value
            // 
            value.Header = "Value";
            value.SortOrder = System.Windows.Forms.SortOrder.None;
            value.TooltipText = null;
            // 
            // min
            // 
            min.Header = "Min";
            min.SortOrder = System.Windows.Forms.SortOrder.None;
            min.TooltipText = null;
            // 
            // max
            // 
            max.Header = "Max";
            max.SortOrder = System.Windows.Forms.SortOrder.None;
            max.TooltipText = null;
            // 
            // nodeImage
            // 
            nodeImage.DataPropertyName = "Image";
            nodeImage.LeftMargin = 1;
            nodeImage.ParentColumn = sensor;
            nodeImage.ScaleMode = Aga.Controls.Tree.ImageScaleMode.Fit;
            // 
            // nodeCheckBox
            // 
            nodeCheckBox.DataPropertyName = "Plot";
            nodeCheckBox.EditEnabled = true;
            nodeCheckBox.LeftMargin = 3;
            nodeCheckBox.ParentColumn = sensor;
            // 
            // nodeTextBoxText
            // 
            nodeTextBoxText.DataPropertyName = "Text";
            nodeTextBoxText.EditEnabled = true;
            nodeTextBoxText.IncrementalSearchEnabled = true;
            nodeTextBoxText.LeftMargin = 3;
            nodeTextBoxText.ParentColumn = sensor;
            nodeTextBoxText.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            nodeTextBoxText.UseCompatibleTextRendering = true;
            // 
            // nodeTextBoxValue
            // 
            nodeTextBoxValue.DataPropertyName = "Value";
            nodeTextBoxValue.IncrementalSearchEnabled = true;
            nodeTextBoxValue.LeftMargin = 3;
            nodeTextBoxValue.ParentColumn = value;
            nodeTextBoxValue.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            nodeTextBoxValue.UseCompatibleTextRendering = true;
            // 
            // nodeTextBoxMin
            // 
            nodeTextBoxMin.DataPropertyName = "Min";
            nodeTextBoxMin.IncrementalSearchEnabled = true;
            nodeTextBoxMin.LeftMargin = 3;
            nodeTextBoxMin.ParentColumn = min;
            nodeTextBoxMin.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            nodeTextBoxMin.UseCompatibleTextRendering = true;
            // 
            // nodeTextBoxMax
            // 
            nodeTextBoxMax.DataPropertyName = "Max";
            nodeTextBoxMax.IncrementalSearchEnabled = true;
            nodeTextBoxMax.LeftMargin = 3;
            nodeTextBoxMax.ParentColumn = max;
            nodeTextBoxMax.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            nodeTextBoxMax.UseCompatibleTextRendering = true;
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileMenuItem, viewMenuItem, optionsMenuItem, helpMenuItem });
            mainMenu.Location = new System.Drawing.Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mainMenu.Size = new System.Drawing.Size(873, 35);
            mainMenu.TabIndex = 0;
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saveReportMenuItem, MenuItem2, resetMenuItem, menuItem5, menuItem6, exitMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Padding = new System.Windows.Forms.Padding(2, 8, 2, 8);
            fileMenuItem.Size = new System.Drawing.Size(33, 35);
            fileMenuItem.Text = "File";
            // 
            // saveReportMenuItem
            // 
            saveReportMenuItem.Name = "saveReportMenuItem";
            saveReportMenuItem.Size = new System.Drawing.Size(145, 22);
            saveReportMenuItem.Text = "Save Report...";
            saveReportMenuItem.Click += saveReportMenuItem_Click;
            // 
            // MenuItem2
            // 
            MenuItem2.Name = "MenuItem2";
            MenuItem2.Size = new System.Drawing.Size(142, 6);
            // 
            // resetMenuItem
            // 
            resetMenuItem.Name = "resetMenuItem";
            resetMenuItem.Size = new System.Drawing.Size(145, 22);
            resetMenuItem.Text = "Reset";
            resetMenuItem.Click += resetClick;
            // 
            // menuItem5
            // 
            menuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mainboardMenuItem, cpuMenuItem, ramMenuItem, gpuMenuItem, fanControllerMenuItem, hddMenuItem, hddMenuItemRemovable, networkMenuItem });
            menuItem5.Name = "menuItem5";
            menuItem5.Size = new System.Drawing.Size(145, 22);
            menuItem5.Text = "Hardware";
            // 
            // mainboardMenuItem
            // 
            mainboardMenuItem.Name = "mainboardMenuItem";
            mainboardMenuItem.Size = new System.Drawing.Size(193, 22);
            mainboardMenuItem.Text = "Mainboard";
            // 
            // cpuMenuItem
            // 
            cpuMenuItem.Name = "cpuMenuItem";
            cpuMenuItem.Size = new System.Drawing.Size(193, 22);
            cpuMenuItem.Text = "CPU";
            // 
            // ramMenuItem
            // 
            ramMenuItem.Name = "ramMenuItem";
            ramMenuItem.Size = new System.Drawing.Size(193, 22);
            ramMenuItem.Text = "RAM";
            // 
            // gpuMenuItem
            // 
            gpuMenuItem.Name = "gpuMenuItem";
            gpuMenuItem.Size = new System.Drawing.Size(193, 22);
            gpuMenuItem.Text = "GPU";
            // 
            // fanControllerMenuItem
            // 
            fanControllerMenuItem.Name = "fanControllerMenuItem";
            fanControllerMenuItem.Size = new System.Drawing.Size(193, 22);
            fanControllerMenuItem.Text = "Fan Controllers";
            // 
            // hddMenuItem
            // 
            hddMenuItem.Name = "hddMenuItem";
            hddMenuItem.Size = new System.Drawing.Size(193, 22);
            hddMenuItem.Text = "Hard Disk Drives";
            // 
            // hddMenuItemRemovable
            // 
            hddMenuItemRemovable.Name = "hddMenuItemRemovable";
            hddMenuItemRemovable.Size = new System.Drawing.Size(193, 22);
            hddMenuItemRemovable.Text = "Removable Disk Drives";
            // 
            // networkMenuItem
            // 
            networkMenuItem.Name = "networkMenuItem";
            networkMenuItem.Size = new System.Drawing.Size(193, 22);
            networkMenuItem.Text = "Network";
            // 
            // menuItem6
            // 
            menuItem6.Name = "menuItem6";
            menuItem6.Size = new System.Drawing.Size(142, 6);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new System.Drawing.Size(145, 22);
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += exitClick;
            // 
            // viewMenuItem
            // 
            viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { resetMinMaxMenuItem, MenuItem3, hiddenMenuItem, plotMenuItem, gadgetMenuItem, MenuItem1, columnsMenuItem });
            viewMenuItem.Name = "viewMenuItem";
            viewMenuItem.Padding = new System.Windows.Forms.Padding(2, 8, 2, 8);
            viewMenuItem.Size = new System.Drawing.Size(40, 35);
            viewMenuItem.Text = "View";
            // 
            // resetMinMaxMenuItem
            // 
            resetMinMaxMenuItem.Name = "resetMinMaxMenuItem";
            resetMinMaxMenuItem.Size = new System.Drawing.Size(188, 22);
            resetMinMaxMenuItem.Text = "Reset Min/Max";
            resetMinMaxMenuItem.Click += resetMinMaxMenuItem_Click;
            // 
            // MenuItem3
            // 
            MenuItem3.Name = "MenuItem3";
            MenuItem3.Size = new System.Drawing.Size(185, 6);
            // 
            // hiddenMenuItem
            // 
            hiddenMenuItem.Name = "hiddenMenuItem";
            hiddenMenuItem.Size = new System.Drawing.Size(188, 22);
            hiddenMenuItem.Text = "Show Hidden Sensors";
            // 
            // plotMenuItem
            // 
            plotMenuItem.Name = "plotMenuItem";
            plotMenuItem.Size = new System.Drawing.Size(188, 22);
            plotMenuItem.Text = "Show Plot";
            // 
            // gadgetMenuItem
            // 
            gadgetMenuItem.Name = "gadgetMenuItem";
            gadgetMenuItem.Size = new System.Drawing.Size(188, 22);
            gadgetMenuItem.Text = "Show Gadget";
            // 
            // MenuItem1
            // 
            MenuItem1.Name = "MenuItem1";
            MenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // columnsMenuItem
            // 
            columnsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { valueMenuItem, minMenuItem, maxMenuItem });
            columnsMenuItem.Name = "columnsMenuItem";
            columnsMenuItem.Size = new System.Drawing.Size(188, 22);
            columnsMenuItem.Text = "Columns";
            // 
            // valueMenuItem
            // 
            valueMenuItem.Name = "valueMenuItem";
            valueMenuItem.Size = new System.Drawing.Size(102, 22);
            valueMenuItem.Text = "Value";
            // 
            // minMenuItem
            // 
            minMenuItem.Name = "minMenuItem";
            minMenuItem.Size = new System.Drawing.Size(102, 22);
            minMenuItem.Text = "Min";
            // 
            // maxMenuItem
            // 
            maxMenuItem.Name = "maxMenuItem";
            maxMenuItem.Size = new System.Drawing.Size(102, 22);
            maxMenuItem.Text = "Max";
            // 
            // optionsMenuItem
            // 
            optionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { startMinMenuItem, minTrayMenuItem, minCloseMenuItem, startupMenuItem, runAsServiceMenuItem, showGadgetWindowTopmostMenuItem, separatorMenuItem, temperatureUnitsMenuItem, plotLocationMenuItem, logSeparatorMenuItem, logSensorsMenuItem, loggingIntervalMenuItem, webMenuItemSeparator, webMenuItem });
            optionsMenuItem.Name = "optionsMenuItem";
            optionsMenuItem.Padding = new System.Windows.Forms.Padding(2, 8, 2, 8);
            optionsMenuItem.Size = new System.Drawing.Size(57, 35);
            optionsMenuItem.Text = "Options";
            // 
            // startMinMenuItem
            // 
            startMinMenuItem.Name = "startMinMenuItem";
            startMinMenuItem.Size = new System.Drawing.Size(322, 22);
            startMinMenuItem.Text = "Start Minimized";
            // 
            // minTrayMenuItem
            // 
            minTrayMenuItem.Name = "minTrayMenuItem";
            minTrayMenuItem.Size = new System.Drawing.Size(322, 22);
            minTrayMenuItem.Text = "Minimize To Tray";
            // 
            // minCloseMenuItem
            // 
            minCloseMenuItem.Name = "minCloseMenuItem";
            minCloseMenuItem.Size = new System.Drawing.Size(322, 22);
            minCloseMenuItem.Text = "Minimize On Close";
            // 
            // startupMenuItem
            // 
            startupMenuItem.Name = "startupMenuItem";
            startupMenuItem.Size = new System.Drawing.Size(322, 22);
            startupMenuItem.Text = "Run On Windows Startup";
            // 
            // runAsServiceMenuItem
            // 
            runAsServiceMenuItem.Name = "runAsServiceMenuItem";
            runAsServiceMenuItem.Size = new System.Drawing.Size(322, 22);
            runAsServiceMenuItem.Text = "Run as Service (no GUI, but starts before logon)";
            // 
            // showGadgetWindowTopmostMenuItem
            // 
            showGadgetWindowTopmostMenuItem.Name = "showGadgetWindowTopmostMenuItem";
            showGadgetWindowTopmostMenuItem.Size = new System.Drawing.Size(322, 22);
            showGadgetWindowTopmostMenuItem.Text = "Show Gadget Window Topmost";
            // 
            // separatorMenuItem
            // 
            separatorMenuItem.Name = "separatorMenuItem";
            separatorMenuItem.Size = new System.Drawing.Size(319, 6);
            // 
            // temperatureUnitsMenuItem
            // 
            temperatureUnitsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { celsiusMenuItem, fahrenheitMenuItem });
            temperatureUnitsMenuItem.Name = "temperatureUnitsMenuItem";
            temperatureUnitsMenuItem.Size = new System.Drawing.Size(322, 22);
            temperatureUnitsMenuItem.Text = "Temperature Unit";
            // 
            // celsiusMenuItem
            // 
            celsiusMenuItem.Name = "celsiusMenuItem";
            celsiusMenuItem.Size = new System.Drawing.Size(130, 22);
            celsiusMenuItem.Text = "Celsius";
            celsiusMenuItem.Click += celsiusMenuItem_Click;
            // 
            // fahrenheitMenuItem
            // 
            fahrenheitMenuItem.Name = "fahrenheitMenuItem";
            fahrenheitMenuItem.Size = new System.Drawing.Size(130, 22);
            fahrenheitMenuItem.Text = "Fahrenheit";
            fahrenheitMenuItem.Click += fahrenheitMenuItem_Click;
            // 
            // plotLocationMenuItem
            // 
            plotLocationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { plotWindowMenuItem, plotBottomMenuItem, plotRightMenuItem });
            plotLocationMenuItem.Name = "plotLocationMenuItem";
            plotLocationMenuItem.Size = new System.Drawing.Size(322, 22);
            plotLocationMenuItem.Text = "Plot Location";
            // 
            // plotWindowMenuItem
            // 
            plotWindowMenuItem.Name = "plotWindowMenuItem";
            plotWindowMenuItem.Size = new System.Drawing.Size(118, 22);
            plotWindowMenuItem.Text = "Window";
            // 
            // plotBottomMenuItem
            // 
            plotBottomMenuItem.Name = "plotBottomMenuItem";
            plotBottomMenuItem.Size = new System.Drawing.Size(118, 22);
            plotBottomMenuItem.Text = "Bottom";
            // 
            // plotRightMenuItem
            // 
            plotRightMenuItem.Name = "plotRightMenuItem";
            plotRightMenuItem.Size = new System.Drawing.Size(118, 22);
            plotRightMenuItem.Text = "Right";
            // 
            // logSeparatorMenuItem
            // 
            logSeparatorMenuItem.Name = "logSeparatorMenuItem";
            logSeparatorMenuItem.Size = new System.Drawing.Size(319, 6);
            // 
            // logSensorsMenuItem
            // 
            logSensorsMenuItem.Name = "logSensorsMenuItem";
            logSensorsMenuItem.Size = new System.Drawing.Size(322, 22);
            logSensorsMenuItem.Text = "Log Sensors";
            // 
            // loggingIntervalMenuItem
            // 
            loggingIntervalMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { log1sMenuItem, log2sMenuItem, log5sMenuItem, log10sMenuItem, log30sMenuItem, log1minMenuItem, log2minMenuItem, log5minMenuItem, log10minMenuItem, log30minMenuItem, log1hMenuItem, log2hMenuItem, log6hMenuItem });
            loggingIntervalMenuItem.Name = "loggingIntervalMenuItem";
            loggingIntervalMenuItem.Size = new System.Drawing.Size(322, 22);
            loggingIntervalMenuItem.Text = "Logging Interval";
            // 
            // log1sMenuItem
            // 
            log1sMenuItem.Name = "log1sMenuItem";
            log1sMenuItem.Size = new System.Drawing.Size(107, 22);
            log1sMenuItem.Text = "1s";
            // 
            // log2sMenuItem
            // 
            log2sMenuItem.Name = "log2sMenuItem";
            log2sMenuItem.Size = new System.Drawing.Size(107, 22);
            log2sMenuItem.Text = "2s";
            // 
            // log5sMenuItem
            // 
            log5sMenuItem.Name = "log5sMenuItem";
            log5sMenuItem.Size = new System.Drawing.Size(107, 22);
            log5sMenuItem.Text = "5s";
            // 
            // log10sMenuItem
            // 
            log10sMenuItem.Name = "log10sMenuItem";
            log10sMenuItem.Size = new System.Drawing.Size(107, 22);
            log10sMenuItem.Text = "10s";
            // 
            // log30sMenuItem
            // 
            log30sMenuItem.Name = "log30sMenuItem";
            log30sMenuItem.Size = new System.Drawing.Size(107, 22);
            log30sMenuItem.Text = "30s";
            // 
            // log1minMenuItem
            // 
            log1minMenuItem.Name = "log1minMenuItem";
            log1minMenuItem.Size = new System.Drawing.Size(107, 22);
            log1minMenuItem.Text = "1min";
            // 
            // log2minMenuItem
            // 
            log2minMenuItem.Name = "log2minMenuItem";
            log2minMenuItem.Size = new System.Drawing.Size(107, 22);
            log2minMenuItem.Text = "2min";
            // 
            // log5minMenuItem
            // 
            log5minMenuItem.Name = "log5minMenuItem";
            log5minMenuItem.Size = new System.Drawing.Size(107, 22);
            log5minMenuItem.Text = "5min";
            // 
            // log10minMenuItem
            // 
            log10minMenuItem.Name = "log10minMenuItem";
            log10minMenuItem.Size = new System.Drawing.Size(107, 22);
            log10minMenuItem.Text = "10min";
            // 
            // log30minMenuItem
            // 
            log30minMenuItem.Name = "log30minMenuItem";
            log30minMenuItem.Size = new System.Drawing.Size(107, 22);
            log30minMenuItem.Text = "30min";
            // 
            // log1hMenuItem
            // 
            log1hMenuItem.Name = "log1hMenuItem";
            log1hMenuItem.Size = new System.Drawing.Size(107, 22);
            log1hMenuItem.Text = "1h";
            // 
            // log2hMenuItem
            // 
            log2hMenuItem.Name = "log2hMenuItem";
            log2hMenuItem.Size = new System.Drawing.Size(107, 22);
            log2hMenuItem.Text = "2h";
            // 
            // log6hMenuItem
            // 
            log6hMenuItem.Name = "log6hMenuItem";
            log6hMenuItem.Size = new System.Drawing.Size(107, 22);
            log6hMenuItem.Text = "6h";
            // 
            // webMenuItemSeparator
            // 
            webMenuItemSeparator.Name = "webMenuItemSeparator";
            webMenuItemSeparator.Size = new System.Drawing.Size(319, 6);
            // 
            // webMenuItem
            // 
            webMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { runWebServerMenuItem, allowRemoteAccessToolStripMenuItem, serverPortMenuItem });
            webMenuItem.Name = "webMenuItem";
            webMenuItem.Size = new System.Drawing.Size(322, 22);
            webMenuItem.Text = "Web Server";
            // 
            // runWebServerMenuItem
            // 
            runWebServerMenuItem.Name = "runWebServerMenuItem";
            runWebServerMenuItem.Size = new System.Drawing.Size(187, 22);
            runWebServerMenuItem.Text = "Run";
            // 
            // allowRemoteAccessToolStripMenuItem
            // 
            allowRemoteAccessToolStripMenuItem.Name = "allowRemoteAccessToolStripMenuItem";
            allowRemoteAccessToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            allowRemoteAccessToolStripMenuItem.Text = "Allow Remote Access";
            // 
            // serverPortMenuItem
            // 
            serverPortMenuItem.Name = "serverPortMenuItem";
            serverPortMenuItem.Size = new System.Drawing.Size(187, 22);
            serverPortMenuItem.Text = "Port...";
            serverPortMenuItem.Click += serverPortMenuItem_Click;
            // 
            // helpMenuItem
            // 
            helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutMenuItem });
            helpMenuItem.Name = "helpMenuItem";
            helpMenuItem.Padding = new System.Windows.Forms.Padding(2, 8, 2, 8);
            helpMenuItem.Size = new System.Drawing.Size(40, 35);
            helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new System.Drawing.Size(107, 22);
            aboutMenuItem.Text = "About";
            aboutMenuItem.Click += aboutMenuItem_Click;
            // 
            // treeContextMenu
            // 
            treeContextMenu.Name = "treeContextMenu";
            treeContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "OpenHardwareMonitor.Report.txt";
            saveFileDialog.Filter = "Text Documents|*.txt|All Files|*.*";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Save Report As";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // splitContainer
            // 
            splitContainer.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
            splitContainer.Color = System.Drawing.SystemColors.Control;
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Location = new System.Drawing.Point(0, 35);
            splitContainer.Margin = new System.Windows.Forms.Padding(55, 19, 55, 19);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(treeView);
            splitContainer.Size = new System.Drawing.Size(873, 472);
            splitContainer.SplitterDistance = 343;
            splitContainer.SplitterWidth = 25;
            splitContainer.TabIndex = 3;
            // 
            // treeView
            // 
            treeView.BackColor = System.Drawing.SystemColors.Window;
            treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            treeView.Columns.Add(sensor);
            treeView.Columns.Add(value);
            treeView.Columns.Add(min);
            treeView.Columns.Add(max);
            treeView.DefaultToolTipProvider = null;
            treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            treeView.DragDropMarkColor = System.Drawing.Color.Black;
            treeView.FullRowSelect = true;
            treeView.FullRowSelectActiveColor = System.Drawing.Color.FromArgb(0, 0, 192);
            treeView.FullRowSelectInactiveColor = System.Drawing.Color.FromArgb(192, 192, 255);
            treeView.GridLineStyle = Aga.Controls.Tree.GridLineStyle.Horizontal;
            treeView.LineColor = System.Drawing.SystemColors.ControlDark;
            treeView.Location = new System.Drawing.Point(0, 0);
            treeView.Margin = new System.Windows.Forms.Padding(55, 19, 55, 19);
            treeView.Model = null;
            treeView.Name = "treeView";
            treeView.NodeControls.Add(nodeImage);
            treeView.NodeControls.Add(nodeCheckBox);
            treeView.NodeControls.Add(nodeTextBoxText);
            treeView.NodeControls.Add(nodeTextBoxValue);
            treeView.NodeControls.Add(nodeTextBoxMin);
            treeView.NodeControls.Add(nodeTextBoxMax);
            treeView.NodeFilter = null;
            treeView.SelectedNode = null;
            treeView.Size = new System.Drawing.Size(873, 343);
            treeView.TabIndex = 0;
            treeView.Text = "treeView";
            treeView.UseColumns = true;
            treeView.NodeMouseDoubleClick += treeView_NodeMouseDoubleClick;
            treeView.Click += treeView_Click;
            treeView.MouseDown += treeView_MouseDown;
            treeView.MouseMove += treeView_MouseMove;
            treeView.MouseUp += treeView_MouseUp;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(873, 507);
            Controls.Add(splitContainer);
            Controls.Add(mainMenu);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenu;
            Margin = new System.Windows.Forms.Padding(55, 19, 55, 19);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Open Hardware Monitor";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ResizeEnd += MainForm_MoveOrResize;
            Move += MainForm_MoveOrResize;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Aga.Controls.Tree.TreeViewAdv treeView;
    private System.Windows.Forms.MenuStrip mainMenu;
    private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    private Aga.Controls.Tree.TreeColumn sensor;
    private Aga.Controls.Tree.TreeColumn value;
    private Aga.Controls.Tree.TreeColumn min;
    private Aga.Controls.Tree.TreeColumn max;
    private Aga.Controls.Tree.NodeControls.NodeIcon nodeImage;
    private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxText;
    private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxValue;
    private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxMin;
    private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxMax;
    private SplitContainerAdv splitContainer;
    private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plotMenuItem;
    private Aga.Controls.Tree.NodeControls.NodeCheckBox nodeCheckBox;
    private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveReportMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hddMenuItem;
    private System.Windows.Forms.ToolStripMenuItem minTrayMenuItem;
    private System.Windows.Forms.ToolStripSeparator separatorMenuItem;
    private System.Windows.Forms.ContextMenuStrip treeContextMenu;
    private System.Windows.Forms.ToolStripMenuItem startMinMenuItem;
    private System.Windows.Forms.ToolStripMenuItem startupMenuItem;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.ToolStripMenuItem hiddenMenuItem;
    private System.Windows.Forms.ToolStripSeparator MenuItem1;
    private System.Windows.Forms.ToolStripMenuItem columnsMenuItem;
    private System.Windows.Forms.ToolStripMenuItem valueMenuItem;
    private System.Windows.Forms.ToolStripMenuItem minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem maxMenuItem;
    private System.Windows.Forms.ToolStripMenuItem temperatureUnitsMenuItem;
    private System.Windows.Forms.ToolStripSeparator webMenuItemSeparator;
    private System.Windows.Forms.ToolStripMenuItem celsiusMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fahrenheitMenuItem;
    private System.Windows.Forms.ToolStripSeparator MenuItem2;
    private System.Windows.Forms.ToolStripMenuItem resetMinMaxMenuItem;
    private System.Windows.Forms.ToolStripSeparator MenuItem3;
    private System.Windows.Forms.ToolStripMenuItem gadgetMenuItem;
    private System.Windows.Forms.ToolStripMenuItem minCloseMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resetMenuItem;
    private System.Windows.Forms.ToolStripSeparator menuItem6;
    private System.Windows.Forms.ToolStripMenuItem plotLocationMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plotWindowMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plotBottomMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plotRightMenuItem;
		private System.Windows.Forms.ToolStripMenuItem webMenuItem;
    private System.Windows.Forms.ToolStripMenuItem runWebServerMenuItem;
    private System.Windows.Forms.ToolStripMenuItem serverPortMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuItem5;
    private System.Windows.Forms.ToolStripMenuItem mainboardMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cpuMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gpuMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fanControllerMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ramMenuItem;
    private System.Windows.Forms.ToolStripMenuItem logSensorsMenuItem;
    private System.Windows.Forms.ToolStripSeparator logSeparatorMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loggingIntervalMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log1sMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log2sMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log5sMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log10sMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log30sMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log1minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log2minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log5minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log10minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log30minMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log1hMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log2hMenuItem;
    private System.Windows.Forms.ToolStripMenuItem log6hMenuItem;
    private System.Windows.Forms.ToolStripMenuItem networkMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hddMenuItemRemovable;
        private System.Windows.Forms.ToolStripMenuItem allowRemoteAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGadgetWindowTopmostMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAsServiceMenuItem;
    }
}

