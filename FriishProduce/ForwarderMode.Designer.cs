﻿
namespace FriishProduce
{
    partial class ForwarderMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForwarderMode));
            this.a000 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.NMode = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Console = new System.Windows.Forms.ComboBox();
            this.page1 = new System.Windows.Forms.Panel();
            this.page2 = new System.Windows.Forms.Panel();
            this.Patch = new System.Windows.Forms.CheckBox();
            this.ROMPath = new System.Windows.Forms.Label();
            this.DeleteBase = new System.Windows.Forms.Button();
            this.AddBase = new System.Windows.Forms.Button();
            this.Bases = new System.Windows.Forms.ComboBox();
            this.OpenROM = new System.Windows.Forms.Button();
            this.a001 = new System.Windows.Forms.Label();
            this.BrowseROM = new System.Windows.Forms.OpenFileDialog();
            this.BrowseWAD = new System.Windows.Forms.OpenFileDialog();
            this.SaveWAD = new System.Windows.Forms.SaveFileDialog();
            this.page3 = new System.Windows.Forms.Panel();
            this.a003 = new System.Windows.Forms.Label();
            this.TitleID = new System.Windows.Forms.TextBox();
            this.a005 = new System.Windows.Forms.Label();
            this.Banner = new System.Windows.Forms.Panel();
            this.a012 = new System.Windows.Forms.Label();
            this.ImgInterp = new System.Windows.Forms.ComboBox();
            this.a011 = new System.Windows.Forms.Label();
            this.ImgResize = new System.Windows.Forms.ComboBox();
            this.SaveDataTitle = new System.Windows.Forms.TextBox();
            this.a010 = new System.Windows.Forms.Label();
            this.ImportBases = new System.Windows.Forms.ComboBox();
            this.Import = new System.Windows.Forms.CheckBox();
            this.Image = new System.Windows.Forms.PictureBox();
            this.Players = new System.Windows.Forms.NumericUpDown();
            this.a009 = new System.Windows.Forms.Label();
            this.ReleaseYear = new System.Windows.Forms.NumericUpDown();
            this.a008 = new System.Windows.Forms.Label();
            this.BannerTitle = new System.Windows.Forms.TextBox();
            this.a007 = new System.Windows.Forms.Label();
            this.a006 = new System.Windows.Forms.Label();
            this.ChannelTitle = new System.Windows.Forms.TextBox();
            this.Custom = new System.Windows.Forms.CheckBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BrowsePatch = new System.Windows.Forms.OpenFileDialog();
            this.BrowseImage = new System.Windows.Forms.OpenFileDialog();
            this.panel.SuspendLayout();
            this.page1.SuspendLayout();
            this.page2.SuspendLayout();
            this.page3.SuspendLayout();
            this.Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Players)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseYear)).BeginInit();
            this.SuspendLayout();
            // 
            // a000
            // 
            resources.ApplyResources(this.a000, "a000");
            this.a000.Name = "a000";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel.Controls.Add(this.NMode);
            this.panel.Controls.Add(this.Settings);
            this.panel.Controls.Add(this.Back);
            this.panel.Controls.Add(this.Save);
            this.panel.Controls.Add(this.Next);
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            this.panel.Tag = "panel";
            // 
            // NMode
            // 
            this.NMode.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.NMode.FlatAppearance.BorderSize = 0;
            this.NMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.NMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.NMode, "NMode");
            this.NMode.Name = "NMode";
            this.NMode.UseVisualStyleBackColor = true;
            this.NMode.Click += new System.EventHandler(this.Forwarders_Click);
            // 
            // Settings
            // 
            this.Settings.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.Settings, "Settings");
            this.Settings.Name = "Settings";
            this.Settings.UseCompatibleTextRendering = true;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Back
            // 
            resources.ApplyResources(this.Back, "Back");
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Back.Name = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Save
            // 
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Finish_Click);
            // 
            // Next
            // 
            resources.ApplyResources(this.Next, "Next");
            this.Next.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Next.Name = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Console
            // 
            this.Console.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Console, "Console");
            this.Console.FormattingEnabled = true;
            this.Console.Items.AddRange(new object[] {
            resources.GetString("Console.Items")});
            this.Console.Name = "Console";
            this.Console.SelectedIndexChanged += new System.EventHandler(this.Console_Changed);
            // 
            // page1
            // 
            this.page1.Controls.Add(this.Console);
            this.page1.Controls.Add(this.a000);
            resources.ApplyResources(this.page1, "page1");
            this.page1.Name = "page1";
            // 
            // page2
            // 
            this.page2.Controls.Add(this.Patch);
            this.page2.Controls.Add(this.ROMPath);
            this.page2.Controls.Add(this.DeleteBase);
            this.page2.Controls.Add(this.AddBase);
            this.page2.Controls.Add(this.Bases);
            this.page2.Controls.Add(this.OpenROM);
            this.page2.Controls.Add(this.a001);
            resources.ApplyResources(this.page2, "page2");
            this.page2.Name = "page2";
            // 
            // Patch
            // 
            resources.ApplyResources(this.Patch, "Patch");
            this.Patch.Name = "Patch";
            this.Patch.Tag = "a014";
            this.Patch.UseVisualStyleBackColor = true;
            this.Patch.CheckedChanged += new System.EventHandler(this.Patch_CheckedChanged);
            // 
            // ROMPath
            // 
            resources.ApplyResources(this.ROMPath, "ROMPath");
            this.ROMPath.Name = "ROMPath";
            this.ROMPath.Tag = "a002";
            // 
            // DeleteBase
            // 
            resources.ApplyResources(this.DeleteBase, "DeleteBase");
            this.DeleteBase.Name = "DeleteBase";
            this.DeleteBase.UseVisualStyleBackColor = true;
            this.DeleteBase.Click += new System.EventHandler(this.DeleteWAD);
            // 
            // AddBase
            // 
            resources.ApplyResources(this.AddBase, "AddBase");
            this.AddBase.Name = "AddBase";
            this.AddBase.UseVisualStyleBackColor = true;
            this.AddBase.Click += new System.EventHandler(this.AddWAD);
            // 
            // Bases
            // 
            this.Bases.DisplayMember = "Base";
            this.Bases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Bases, "Bases");
            this.Bases.FormattingEnabled = true;
            this.Bases.Name = "Bases";
            this.Bases.SelectedIndexChanged += new System.EventHandler(this.BaseList_Changed);
            // 
            // OpenROM
            // 
            resources.ApplyResources(this.OpenROM, "OpenROM");
            this.OpenROM.Name = "OpenROM";
            this.OpenROM.UseVisualStyleBackColor = true;
            this.OpenROM.Click += new System.EventHandler(this.OpenROM_Click);
            // 
            // a001
            // 
            resources.ApplyResources(this.a001, "a001");
            this.a001.Name = "a001";
            // 
            // BrowseWAD
            // 
            resources.ApplyResources(this.BrowseWAD, "BrowseWAD");
            // 
            // SaveWAD
            // 
            this.SaveWAD.DefaultExt = "wad";
            // 
            // page3
            // 
            this.page3.Controls.Add(this.a003);
            this.page3.Controls.Add(this.TitleID);
            this.page3.Controls.Add(this.a005);
            this.page3.Controls.Add(this.Banner);
            this.page3.Controls.Add(this.Custom);
            resources.ApplyResources(this.page3, "page3");
            this.page3.Name = "page3";
            // 
            // a003
            // 
            resources.ApplyResources(this.a003, "a003");
            this.a003.Name = "a003";
            // 
            // TitleID
            // 
            this.TitleID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.TitleID, "TitleID");
            this.TitleID.Name = "TitleID";
            this.TitleID.TextChanged += new System.EventHandler(this.TitleID_Changed);
            // 
            // a005
            // 
            resources.ApplyResources(this.a005, "a005");
            this.a005.Name = "a005";
            this.a005.Tag = "a005";
            // 
            // Banner
            // 
            this.Banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Banner.Controls.Add(this.a012);
            this.Banner.Controls.Add(this.ImgInterp);
            this.Banner.Controls.Add(this.a011);
            this.Banner.Controls.Add(this.ImgResize);
            this.Banner.Controls.Add(this.SaveDataTitle);
            this.Banner.Controls.Add(this.a010);
            this.Banner.Controls.Add(this.ImportBases);
            this.Banner.Controls.Add(this.Import);
            this.Banner.Controls.Add(this.Image);
            this.Banner.Controls.Add(this.Players);
            this.Banner.Controls.Add(this.a009);
            this.Banner.Controls.Add(this.ReleaseYear);
            this.Banner.Controls.Add(this.a008);
            this.Banner.Controls.Add(this.BannerTitle);
            this.Banner.Controls.Add(this.a007);
            this.Banner.Controls.Add(this.a006);
            this.Banner.Controls.Add(this.ChannelTitle);
            resources.ApplyResources(this.Banner, "Banner");
            this.Banner.Name = "Banner";
            // 
            // a012
            // 
            resources.ApplyResources(this.a012, "a012");
            this.a012.Name = "a012";
            // 
            // ImgInterp
            // 
            this.ImgInterp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ImgInterp, "ImgInterp");
            this.ImgInterp.FormattingEnabled = true;
            this.ImgInterp.Items.AddRange(new object[] {
            resources.GetString("ImgInterp.Items")});
            this.ImgInterp.Name = "ImgInterp";
            this.ImgInterp.SelectedIndexChanged += new System.EventHandler(this.Image_ModeIChanged);
            // 
            // a011
            // 
            resources.ApplyResources(this.a011, "a011");
            this.a011.Name = "a011";
            // 
            // ImgResize
            // 
            this.ImgResize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ImgResize, "ImgResize");
            this.ImgResize.FormattingEnabled = true;
            this.ImgResize.Items.AddRange(new object[] {
            resources.GetString("ImgResize.Items")});
            this.ImgResize.Name = "ImgResize";
            this.ImgResize.SelectedIndexChanged += new System.EventHandler(this.Image_StretchChanged);
            // 
            // SaveDataTitle
            // 
            resources.ApplyResources(this.SaveDataTitle, "SaveDataTitle");
            this.SaveDataTitle.Name = "SaveDataTitle";
            this.SaveDataTitle.TextChanged += new System.EventHandler(this.BannerText_Changed);
            this.SaveDataTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BannerText_KeyPress);
            // 
            // a010
            // 
            resources.ApplyResources(this.a010, "a010");
            this.a010.Name = "a010";
            // 
            // ImportBases
            // 
            this.ImportBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ImportBases, "ImportBases");
            this.ImportBases.FormattingEnabled = true;
            this.ImportBases.Name = "ImportBases";
            // 
            // Import
            // 
            resources.ApplyResources(this.Import, "Import");
            this.Import.Name = "Import";
            this.Import.Tag = "a016";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.CheckedChanged += new System.EventHandler(this.CheckedToggles);
            // 
            // Image
            // 
            this.Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Image.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Image, "Image");
            this.Image.Name = "Image";
            this.Image.TabStop = false;
            this.Image.Click += new System.EventHandler(this.Image_Click);
            // 
            // Players
            // 
            resources.ApplyResources(this.Players, "Players");
            this.Players.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Players.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Players.Name = "Players";
            this.Players.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // a009
            // 
            resources.ApplyResources(this.a009, "a009");
            this.a009.Name = "a009";
            // 
            // ReleaseYear
            // 
            resources.ApplyResources(this.ReleaseYear, "ReleaseYear");
            this.ReleaseYear.Maximum = new decimal(new int[] {
            2029,
            0,
            0,
            0});
            this.ReleaseYear.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.ReleaseYear.Name = "ReleaseYear";
            this.ReleaseYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // a008
            // 
            resources.ApplyResources(this.a008, "a008");
            this.a008.Name = "a008";
            // 
            // BannerTitle
            // 
            resources.ApplyResources(this.BannerTitle, "BannerTitle");
            this.BannerTitle.Name = "BannerTitle";
            this.BannerTitle.TextChanged += new System.EventHandler(this.BannerText_Changed);
            this.BannerTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BannerText_KeyPress);
            // 
            // a007
            // 
            resources.ApplyResources(this.a007, "a007");
            this.a007.Name = "a007";
            // 
            // a006
            // 
            resources.ApplyResources(this.a006, "a006");
            this.a006.Name = "a006";
            // 
            // ChannelTitle
            // 
            resources.ApplyResources(this.ChannelTitle, "ChannelTitle");
            this.ChannelTitle.Name = "ChannelTitle";
            this.ChannelTitle.TextChanged += new System.EventHandler(this.BannerText_Changed);
            // 
            // Custom
            // 
            resources.ApplyResources(this.Custom, "Custom");
            this.Custom.Name = "Custom";
            this.Custom.Tag = "a015";
            this.Custom.UseVisualStyleBackColor = true;
            this.Custom.CheckedChanged += new System.EventHandler(this.CheckedToggles);
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.LemonChiffon;
            this.ToolTip.ForeColor = System.Drawing.Color.Black;
            this.ToolTip.InitialDelay = 300;
            this.ToolTip.ReshowDelay = 100;
            // 
            // BrowsePatch
            // 
            resources.ApplyResources(this.BrowsePatch, "BrowsePatch");
            // 
            // BrowseImage
            // 
            resources.ApplyResources(this.BrowseImage, "BrowseImage");
            // 
            // ForwarderMode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel);
            this.Controls.Add(this.page2);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.page3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ForwarderMode";
            this.panel.ResumeLayout(false);
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            this.page3.ResumeLayout(false);
            this.page3.PerformLayout();
            this.Banner.ResumeLayout(false);
            this.Banner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Players)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label a000;
        internal System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox Console;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel page1;
        private System.Windows.Forms.Panel page2;
        private System.Windows.Forms.Label a001;
        private System.Windows.Forms.Button OpenROM;
        private System.Windows.Forms.OpenFileDialog BrowseROM;
        private System.Windows.Forms.OpenFileDialog BrowseWAD;
        private System.Windows.Forms.SaveFileDialog SaveWAD;
        private System.Windows.Forms.ComboBox Bases;
        private System.Windows.Forms.Button AddBase;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button DeleteBase;
        private System.Windows.Forms.Label ROMPath;
        private System.Windows.Forms.Panel page3;
        private System.Windows.Forms.Label a003;
        private System.Windows.Forms.CheckBox Custom;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Panel Banner;
        private System.Windows.Forms.Label a005;
        private System.Windows.Forms.TextBox TitleID;
        private System.Windows.Forms.CheckBox Patch;
        private System.Windows.Forms.OpenFileDialog BrowsePatch;
        private System.Windows.Forms.Label a006;
        private System.Windows.Forms.TextBox ChannelTitle;
        private System.Windows.Forms.TextBox BannerTitle;
        private System.Windows.Forms.Label a007;
        private System.Windows.Forms.Label a008;
        private System.Windows.Forms.NumericUpDown ReleaseYear;
        private System.Windows.Forms.NumericUpDown Players;
        private System.Windows.Forms.Label a009;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.CheckBox Import;
        private System.Windows.Forms.ComboBox ImportBases;
        private System.Windows.Forms.Label a010;
        private System.Windows.Forms.TextBox SaveDataTitle;
        private System.Windows.Forms.OpenFileDialog BrowseImage;
        private System.Windows.Forms.ComboBox ImgResize;
        private System.Windows.Forms.Label a011;
        private System.Windows.Forms.Label a012;
        private System.Windows.Forms.ComboBox ImgInterp;
        private System.Windows.Forms.Button NMode;
    }
}
