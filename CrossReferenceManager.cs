using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanterIntegration.BizTalk.CrossReference
{
    using Microsoft.BizTalk.CrossReferencing;

    public partial class CrossReferenceManager : Form
    {
        private Button btnDelAppID;
        private Button btnGetAppID;
        private Button btnGetCommonID;
        private Button btnSetCommonID;
        private Label lblApplicationID;
        private Label lblApplicationInstance;
        private Label lblCommonID;
        private Label lblCrossReference;
        private Label lblResult;
        private TextBox tbAppID;
        private TextBox tbAppInstance;
        private TextBox tbCommonID;
        private TextBox tbidXRef;
        private Label lbidXRef;
        private Label lbAppInstance;
        private Label lbAppID;
        private Label lbCommonID;
        private TextBox tbResult;
        public CrossReferenceManager()
        {
            InitializeComponent();
        }
        private void btnGetAppID_Click(object sender, EventArgs e)
        {
            this.tbResult.BackColor = Color.Black;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.tbAppID.Text = Microsoft.BizTalk.CrossReferencing.CrossReferencing.GetAppID(this.tbidXRef.Text, this.tbAppInstance.Text, this.tbCommonID.Text);
                if (this.tbAppID.Text.Length == 0)
                {
                    this.tbResult.Text = "Common ID '" + this.tbCommonID.Text + "' Not found";
                    this.tbResult.BackColor = Color.DarkRed;
                }
                else
                {
                    this.tbResult.Text = "Got Application ID '" + this.tbAppID.Text + "'";
                }
            }
            catch (RuntimeException exRuntimeException)
            {
                this.tbResult.Text = exRuntimeException.Message;
                this.tbResult.BackColor = Color.DarkRed;
            }
            catch (SystemException exSystemException)
            {
                this.tbResult.Text = "Unknown Error: " + exSystemException.Message;
                this.tbResult.BackColor = Color.DarkRed;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnGetCommonID_Click(object sender, EventArgs e)
        {
            this.tbResult.BackColor = Color.Black;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.tbCommonID.Text = Microsoft.BizTalk.CrossReferencing.CrossReferencing.GetCommonID(this.tbidXRef.Text, this.tbAppInstance.Text, this.tbAppID.Text);
                if (this.tbCommonID.Text.Length == 0)
                {
                    this.tbResult.Text = "Application ID '" + this.tbAppID.Text + "' Not found";
                    this.tbResult.BackColor = Color.DarkRed;
                }
                else
                {
                    this.tbResult.Text = "Got Common ID '" + this.tbCommonID.Text + "'";
                }
            }
            catch (RuntimeException exception)
            {
                this.tbResult.Text = exception.Message;
                this.tbResult.BackColor = Color.DarkRed;
            }
            catch (SystemException exception2)
            {
                this.tbResult.Text = "Unknown Error: " + exception2.Message;
                this.tbResult.BackColor = Color.DarkRed;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnRemoveAppID_Click(object sender, EventArgs e)
        {
            this.tbResult.BackColor = Color.Black;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Microsoft.BizTalk.CrossReferencing.CrossReferencing.RemoveAppID(this.tbidXRef.Text, this.tbAppInstance.Text, this.tbAppID.Text))
                {
                    this.tbResult.Text = "Application ID '" + this.tbAppID.Text + "' Removed";
                    this.tbCommonID.Text = "";
                    this.tbAppID.Text = "";
                }
                else
                {
                    this.tbResult.Text = "Application ID '" + this.tbAppID.Text + "' Not Removed";
                    this.tbResult.BackColor = Color.DarkRed;
                }
            }
            catch (RuntimeException exRuntimeException)
            {
                this.tbResult.Text = exRuntimeException.Message;
                this.tbResult.BackColor = Color.DarkRed;
            }
            catch (SystemException exSystemException)
            {
                this.tbResult.Text = "Unknown Error: " + exSystemException.Message;
                this.tbResult.BackColor = Color.DarkRed;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnSetCommonID_Click(object sender, EventArgs e)
        {
            this.tbResult.BackColor = Color.Black;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string text = null;
                if (this.tbCommonID.Text.Length > 0)
                {
                    text = this.tbCommonID.Text;
                }
                if (Microsoft.BizTalk.CrossReferencing.CrossReferencing.GetCommonID(this.tbidXRef.Text, this.tbAppInstance.Text, this.tbAppID.Text).Length > 0)
                {
                    Microsoft.BizTalk.CrossReferencing.CrossReferencing.RemoveAppID(this.tbidXRef.Text, this.tbAppInstance.Text, this.tbAppID.Text);
                }
                this.tbCommonID.Text = Microsoft.BizTalk.CrossReferencing.CrossReferencing.SetCommonID(this.tbidXRef.Text, this.tbAppInstance.Text, this.tbAppID.Text, text);
                if (this.tbCommonID.Text.Length == 0)
                {
                    this.tbResult.Text = "Application ID '" + this.tbAppID.Text + "' not set";
                    this.tbResult.BackColor = Color.DarkRed;
                }
                else
                {
                    this.tbResult.Text = "Application ID '" + this.tbAppID.Text + "', Common ID '" + this.tbCommonID.Text + "' set";
                }
            }
            catch (RuntimeException exception)
            {
                this.tbResult.Text = exception.Message;
                this.tbResult.BackColor = Color.DarkRed;
            }
            catch (SystemException exception2)
            {
                this.tbResult.Text = "Unknown Error: " + exception2.Message;
                this.tbResult.BackColor = Color.DarkRed;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void tcTextBox_Changed(object sender, EventArgs e)
        {
            this.btnGetCommonID.Enabled = (
                (this.tbAppID.Text.Length > 0) &&
                (this.tbAppInstance.Text.Length > 0)) &&
                (this.tbidXRef.Text.Length > 0);
            this.btnGetAppID.Enabled = (
                (this.tbCommonID.Text.Length > 0) &&
                (this.tbAppInstance.Text.Length > 0)) &&
                (this.tbidXRef.Text.Length > 0);
            this.btnDelAppID.Enabled = (
                (this.tbAppID.Text.Length > 0) &&
                (this.tbAppInstance.Text.Length > 0)) &&
                (this.tbidXRef.Text.Length > 0);
            this.btnSetCommonID.Enabled = (
                (this.tbAppID.Text.Length > 0) &&
                (this.tbAppInstance.Text.Length > 0)) &&
                (this.tbidXRef.Text.Length > 0);
            this.lbCommonID.Text = this.tbCommonID.Text.Length.ToString();
            this.lbAppID.Text = this.tbAppID.Text.Length.ToString();
            this.lbAppInstance.Text = this.tbAppInstance.Text.Length.ToString();
            this.lbidXRef.Text = this.tbidXRef.Text.Length.ToString();
            if (this.lbAppInstance.Text == "50")
            {
                this.lbAppInstance.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                this.lbAppInstance.BackColor = System.Drawing.SystemColors.Control;
            }
            if (this.lbCommonID.Text == "50")
            {
                this.lbCommonID.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                this.lbCommonID.BackColor = System.Drawing.SystemColors.Control;
            }
            if (this.lbAppID.Text == "50")
            {
                this.lbAppID.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                this.lbAppID.BackColor = System.Drawing.SystemColors.Control;
            }
            if (this.lbidXRef.Text == "50")
            {
                this.lbidXRef.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                this.lbidXRef.BackColor = System.Drawing.SystemColors.Control;
            }
        }

    }
}
