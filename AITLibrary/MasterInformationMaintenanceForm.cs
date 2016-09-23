using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITLibrary
{
    public partial class MasterInformationMaintenanceForm : LybraryTemplateForm
    {
        public MasterInformationMaintenanceForm()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = "[...]";
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                textBoxName.Text = "";

                dataGridViewMasterInformation.DataSource = null;
                MasterLogic masterLogic = new MasterLogic();

                switch (comboBoxMasterInformation.SelectedItem.ToString())
                {
                    case "Author":
                        dataGridViewMasterInformation.DataSource = masterLogic.GetAllAuthors();
                        break;
                    case "Category":
                        dataGridViewMasterInformation.DataSource = masterLogic.GetAllCategories();
                        break;
                    case "Language":
                        dataGridViewMasterInformation.DataSource = masterLogic.GetAllLanguages();
                        break;
                }

                dataGridViewMasterInformation.Columns["ID"].Visible = false;

            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! " + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "Sorry, something went wrong! Please contact the system support team.";
            }
        }

        private void MasterInformationMaintenanceForm_Load(object sender, EventArgs e)
        {
            comboBoxMasterInformation.SelectedIndex = 0;
        }

        private void refreshNameTexBox(object sender, EventArgs e)
        {
            this.refreshNameTexBox();
        }

        private void refreshNameTexBox()
        {
            textBoxName.Text = "";
            if (dataGridViewMasterInformation.DataSource != null && dataGridViewMasterInformation.SelectedRows.Count > 0)
            {
                int descriptionColumnIndex = (int)AppEnum.TabMasterModel.Description;
                textBoxName.Text = dataGridViewMasterInformation.SelectedRows[0].Cells[descriptionColumnIndex].Value.ToString();
            }
        }

        private void dataGridViewMasterInformation_Click(object sender, EventArgs e)
        {
            refreshNameTexBox();
        }

        private void radioInsert_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                labelSystemMessage.Text = "[...]";

                if (radioInsert.Checked)
                {
                    if (textBoxName.Text.Length == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = "Please, insert a name to continue.";
                    }
                    else
                    {
                        int resultOperation = 0;
                        MasterLogic masterLogic = new MasterLogic();
                        switch (comboBoxMasterInformation.SelectedItem.ToString())
                        {
                            case "Author":                              
                                resultOperation = masterLogic.insertAuthor(textBoxName.Text);
                                break;
                            case "Category":
                                resultOperation = masterLogic.insertCategory(textBoxName.Text);
                                break;
                            case "Language":
                                resultOperation = masterLogic.insertLanguage(textBoxName.Text);
                                break;
                        }

                        if (resultOperation == 0)
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                            labelSystemMessage.Text = "Name could not be inserted. Contact the System Administrator.";
                        }
                        else
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                            labelSystemMessage.Text = "Name inserted with success.";
                        }
                    }
                }
                else if (radioUpdate.Checked)
                {
                    if ((textBoxName.Text.Length == 0)||
                        (dataGridViewMasterInformation.DataSource == null && dataGridViewMasterInformation.SelectedRows.Count == 0))
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = "Please, select one register to continue.";
                    }
                    else
                    {
                        int resultOperation = 0;
                        MasterLogic masterLogic = new MasterLogic();
                        int iDColumnIndex = (int)AppEnum.TabMasterModel.ID;
                        int informationID = (int)dataGridViewMasterInformation.SelectedRows[0].Cells[iDColumnIndex].Value;

                        switch (comboBoxMasterInformation.SelectedItem.ToString())
                        {
                            case "Author":
                                resultOperation = masterLogic.updateAuthor(textBoxName.Text, informationID);
                                break;
                            case "Category":
                                resultOperation = masterLogic.updateCategory(textBoxName.Text, informationID);
                                break;
                            case "Language":
                                resultOperation = masterLogic.updateLanguage(textBoxName.Text, informationID);
                                break;
                        }

                        if (resultOperation == 0)
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                            labelSystemMessage.Text = "Name could not be updated. Contact the System Administrator.";
                        }
                        else
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                            labelSystemMessage.Text = "Name updated with success.";
                        }
                    }

                }
                else if (radioDelete.Checked)
                {
                    if ((textBoxName.Text.Length == 0) ||
                        (dataGridViewMasterInformation.DataSource == null && dataGridViewMasterInformation.SelectedRows.Count == 0))
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = "Please, select one register to continue.";
                    }
                    else
                    {
                        int resultOperation = 0;
                        MasterLogic masterLogic = new MasterLogic();
                        int iDColumnIndex = (int)AppEnum.TabMasterModel.ID;
                        int informationID = (int)dataGridViewMasterInformation.SelectedRows[0].Cells[iDColumnIndex].Value;

                        switch (comboBoxMasterInformation.SelectedItem.ToString())
                        {
                            case "Author":
                                resultOperation = masterLogic.DeleteAuthor(informationID);
                                break;
                            case "Category":
                                resultOperation = masterLogic.DeleteCategory(informationID);
                                break;
                            case "Language":
                                resultOperation = masterLogic.DeleteLanguage(informationID);
                                break;
                        }

                        if (resultOperation == 0)
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                            labelSystemMessage.Text = "Name could not be deleted. Contact the System Administrator.";
                        }
                        else
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                            labelSystemMessage.Text = "Name deleted with success.";
                        }
                    }
                }
                else
                {
                    labelSystemMessage.Text = "Please, select an action to execute.";
                }
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! " + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "Sorry, something went wrong! Please contact the system support team.";
            }
        }

        private void comboBoxMasterInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = "[...]";
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                textBoxName.Text = "";

                dataGridViewMasterInformation.DataSource = null;
                MasterLogic masterLogic = new MasterLogic();

                switch (comboBoxMasterInformation.SelectedItem.ToString())
                {
                    case "Author":
                        dataGridViewMasterInformation.DataSource = masterLogic.GetAllAuthors();
                        break;
                    case "Category":
                        dataGridViewMasterInformation.DataSource = masterLogic.GetAllCategories();
                        break;
                    case "Language":
                        dataGridViewMasterInformation.DataSource = masterLogic.GetAllLanguages();
                        break;
                }

                dataGridViewMasterInformation.Columns["ID"].Visible = false;

            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "This action can not be completed! " + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = "Sorry, something went wrong! Please contact the system support team.";
            }
        }


    }
}
