namespace CanterIntegration.BizTalk.CrossReference
{
    partial class CrossReferenceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrossReferenceManager));
            this.lblCommonID = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblApplicationInstance = new System.Windows.Forms.Label();
            this.lblCrossReference = new System.Windows.Forms.Label();
            this.tbCommonID = new System.Windows.Forms.TextBox();
            this.btnGetCommonID = new System.Windows.Forms.Button();
            this.tbidXRef = new System.Windows.Forms.TextBox();
            this.tbAppInstance = new System.Windows.Forms.TextBox();
            this.tbAppID = new System.Windows.Forms.TextBox();
            this.btnDelAppID = new System.Windows.Forms.Button();
            this.btnGetAppID = new System.Windows.Forms.Button();
            this.btnSetCommonID = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lbidXRef = new System.Windows.Forms.Label();
            this.lbAppInstance = new System.Windows.Forms.Label();
            this.lbAppID = new System.Windows.Forms.Label();
            this.lbCommonID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCommonID
            // 
            this.lblCommonID.AutoSize = true;
            this.lblCommonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommonID.Location = new System.Drawing.Point(57, 106);
            this.lblCommonID.Name = "lblCommonID";
            this.lblCommonID.Size = new System.Drawing.Size(76, 15);
            this.lblCommonID.TabIndex = 6;
            this.lblCommonID.Text = "Co&mmon ID:";
            this.lblCommonID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(49, 74);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(85, 15);
            this.lblApplicationID.TabIndex = 4;
            this.lblApplicationID.Text = "Application I&D:";
            this.lblApplicationID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblApplicationInstance
            // 
            this.lblApplicationInstance.AutoSize = true;
            this.lblApplicationInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationInstance.Location = new System.Drawing.Point(12, 42);
            this.lblApplicationInstance.Name = "lblApplicationInstance";
            this.lblApplicationInstance.Size = new System.Drawing.Size(119, 15);
            this.lblApplicationInstance.TabIndex = 2;
            this.lblApplicationInstance.Text = "&Application Instance:";
            // 
            // lblCrossReference
            // 
            this.lblCrossReference.AutoSize = true;
            this.lblCrossReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrossReference.Location = new System.Drawing.Point(25, 10);
            this.lblCrossReference.Name = "lblCrossReference";
            this.lblCrossReference.Size = new System.Drawing.Size(101, 15);
            this.lblCrossReference.TabIndex = 0;
            this.lblCrossReference.Text = "&Cross Reference:";
            // 
            // tbCommonID
            // 
            this.tbCommonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommonID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCommonID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCommonID.BackColor = System.Drawing.SystemColors.Window;
            this.tbCommonID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCommonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCommonID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCommonID.Location = new System.Drawing.Point(156, 107);
            this.tbCommonID.MaxLength = 50;
            this.tbCommonID.Name = "tbCommonID";
            this.tbCommonID.Size = new System.Drawing.Size(427, 14);
            this.tbCommonID.TabIndex = 7;
            this.tbCommonID.TextChanged += new System.EventHandler(this.tcTextBox_Changed);
            // 
            // btnGetCommonID
            // 
            this.btnGetCommonID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGetCommonID.Enabled = false;
            this.btnGetCommonID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetCommonID.FlatAppearance.BorderSize = 0;
            this.btnGetCommonID.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGetCommonID.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGetCommonID.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGetCommonID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetCommonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCommonID.Location = new System.Drawing.Point(15, 178);
            this.btnGetCommonID.Name = "btnGetCommonID";
            this.btnGetCommonID.Size = new System.Drawing.Size(124, 25);
            this.btnGetCommonID.TabIndex = 10;
            this.btnGetCommonID.Text = "&Get Common ID";
            this.btnGetCommonID.UseVisualStyleBackColor = true;
            this.btnGetCommonID.Click += new System.EventHandler(this.btnGetCommonID_Click);
            // 
            // tbidXRef
            // 
            this.tbidXRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbidXRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbidXRef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbidXRef.BackColor = System.Drawing.SystemColors.Window;
            this.tbidXRef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbidXRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbidXRef.Location = new System.Drawing.Point(156, 11);
            this.tbidXRef.MaxLength = 50;
            this.tbidXRef.Name = "tbidXRef";
            this.tbidXRef.Size = new System.Drawing.Size(427, 14);
            this.tbidXRef.TabIndex = 1;
            this.tbidXRef.TextChanged += new System.EventHandler(this.tcTextBox_Changed);
            // 
            // tbAppInstance
            // 
            this.tbAppInstance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAppInstance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbAppInstance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbAppInstance.BackColor = System.Drawing.SystemColors.Window;
            this.tbAppInstance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAppInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAppInstance.Location = new System.Drawing.Point(156, 43);
            this.tbAppInstance.MaxLength = 50;
            this.tbAppInstance.Name = "tbAppInstance";
            this.tbAppInstance.Size = new System.Drawing.Size(427, 14);
            this.tbAppInstance.TabIndex = 3;
            this.tbAppInstance.TextChanged += new System.EventHandler(this.tcTextBox_Changed);
            // 
            // tbAppID
            // 
            this.tbAppID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAppID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbAppID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbAppID.BackColor = System.Drawing.SystemColors.Window;
            this.tbAppID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAppID.Location = new System.Drawing.Point(156, 75);
            this.tbAppID.MaxLength = 50;
            this.tbAppID.Name = "tbAppID";
            this.tbAppID.Size = new System.Drawing.Size(427, 14);
            this.tbAppID.TabIndex = 5;
            this.tbAppID.TextChanged += new System.EventHandler(this.tcTextBox_Changed);
            // 
            // btnDelAppID
            // 
            this.btnDelAppID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelAppID.Enabled = false;
            this.btnDelAppID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelAppID.FlatAppearance.BorderSize = 0;
            this.btnDelAppID.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelAppID.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDelAppID.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelAppID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAppID.Location = new System.Drawing.Point(327, 178);
            this.btnDelAppID.Name = "btnDelAppID";
            this.btnDelAppID.Size = new System.Drawing.Size(124, 25);
            this.btnDelAppID.TabIndex = 12;
            this.btnDelAppID.Text = "De&l Application ID";
            this.btnDelAppID.UseVisualStyleBackColor = true;
            this.btnDelAppID.Click += new System.EventHandler(this.btnRemoveAppID_Click);
            // 
            // btnGetAppID
            // 
            this.btnGetAppID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGetAppID.Enabled = false;
            this.btnGetAppID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetAppID.FlatAppearance.BorderSize = 0;
            this.btnGetAppID.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGetAppID.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGetAppID.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGetAppID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAppID.Location = new System.Drawing.Point(171, 178);
            this.btnGetAppID.Name = "btnGetAppID";
            this.btnGetAppID.Size = new System.Drawing.Size(124, 25);
            this.btnGetAppID.TabIndex = 11;
            this.btnGetAppID.Text = "G&et Application ID";
            this.btnGetAppID.UseVisualStyleBackColor = true;
            this.btnGetAppID.Click += new System.EventHandler(this.btnGetAppID_Click);
            // 
            // btnSetCommonID
            // 
            this.btnSetCommonID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSetCommonID.Enabled = false;
            this.btnSetCommonID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetCommonID.FlatAppearance.BorderSize = 0;
            this.btnSetCommonID.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSetCommonID.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSetCommonID.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSetCommonID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetCommonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCommonID.Location = new System.Drawing.Point(483, 178);
            this.btnSetCommonID.Name = "btnSetCommonID";
            this.btnSetCommonID.Size = new System.Drawing.Size(124, 25);
            this.btnSetCommonID.TabIndex = 13;
            this.btnSetCommonID.Text = "&Set Common ID";
            this.btnSetCommonID.UseVisualStyleBackColor = true;
            this.btnSetCommonID.Click += new System.EventHandler(this.btnSetCommonID_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(96, 136);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 15);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "&Result:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.ForeColor = System.Drawing.SystemColors.Window;
            this.tbResult.Location = new System.Drawing.Point(156, 137);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(427, 14);
            this.tbResult.TabIndex = 9;
            this.tbResult.Text = "Ok";
            // 
            // lbidXRef
            // 
            this.lbidXRef.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbidXRef.AutoSize = true;
            this.lbidXRef.BackColor = System.Drawing.SystemColors.Control;
            this.lbidXRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbidXRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidXRef.Location = new System.Drawing.Point(590, 10);
            this.lbidXRef.Name = "lbidXRef";
            this.lbidXRef.Size = new System.Drawing.Size(14, 15);
            this.lbidXRef.TabIndex = 14;
            this.lbidXRef.Text = "0";
            // 
            // lbAppInstance
            // 
            this.lbAppInstance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbAppInstance.AutoSize = true;
            this.lbAppInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAppInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppInstance.Location = new System.Drawing.Point(590, 42);
            this.lbAppInstance.Name = "lbAppInstance";
            this.lbAppInstance.Size = new System.Drawing.Size(14, 15);
            this.lbAppInstance.TabIndex = 15;
            this.lbAppInstance.Text = "0";
            // 
            // lbAppID
            // 
            this.lbAppID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbAppID.AutoSize = true;
            this.lbAppID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppID.Location = new System.Drawing.Point(590, 74);
            this.lbAppID.Name = "lbAppID";
            this.lbAppID.Size = new System.Drawing.Size(14, 15);
            this.lbAppID.TabIndex = 16;
            this.lbAppID.Text = "0";
            // 
            // lbCommonID
            // 
            this.lbCommonID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCommonID.AutoSize = true;
            this.lbCommonID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCommonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommonID.Location = new System.Drawing.Point(590, 106);
            this.lbCommonID.Name = "lbCommonID";
            this.lbCommonID.Size = new System.Drawing.Size(14, 15);
            this.lbCommonID.TabIndex = 17;
            this.lbCommonID.Text = "0";
            // 
            // CrossReferenceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 216);
            this.Controls.Add(this.lbCommonID);
            this.Controls.Add(this.lbAppID);
            this.Controls.Add(this.lbAppInstance);
            this.Controls.Add(this.lbidXRef);
            this.Controls.Add(this.lblCommonID);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblApplicationID);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblApplicationInstance);
            this.Controls.Add(this.lblCrossReference);
            this.Controls.Add(this.tbCommonID);
            this.Controls.Add(this.tbidXRef);
            this.Controls.Add(this.tbAppID);
            this.Controls.Add(this.tbAppInstance);
            this.Controls.Add(this.btnDelAppID);
            this.Controls.Add(this.btnGetCommonID);
            this.Controls.Add(this.btnGetAppID);
            this.Controls.Add(this.btnSetCommonID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(99999, 255);
            this.MinimumSize = new System.Drawing.Size(647, 255);
            this.Name = "CrossReferenceManager";
            this.Text = "Cross Reference Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

