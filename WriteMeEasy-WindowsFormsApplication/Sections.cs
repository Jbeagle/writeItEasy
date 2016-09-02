﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WriteMeEasy_WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private void includeSectionLabelsCheck_CheckedChanged(object sender, EventArgs e)
        {
            int numSections = contentSections.Count;
            int sectionMult = numSections * 27;
            int totalSpace = 243 + sectionMult;
            if (includeSectionLabelsCheck.Checked)
            {
                lowerSection(243, "SECTIONS");
                sections["SECTIONS"] += 243;

                for (int i = 1; i <= numSections; i++)
                {
                    Label sectionLabelLabel = (Label)Controls.Find("section" + i + "LabelLabel", true)[0];
                    sectionLabelLabel.Enabled = true;
                    TextBox sectionLabelEnter = (TextBox)Controls.Find("section" + i + "LabelEnter", true)[0];
                    sectionLabelEnter.Enabled = true;
                }

                addSpace("sectionsDefaultButton", 243, "sectionsPanel", "SECTIONS");
                sectionLabelGroupBox.Height = 288;
                sectionLabelLocationGroupBox.Visible = true;
                sectionLabelStyleGroupBox.Visible = true;
            }
            else
            {
                raiseSection(243, "SECTIONS");
                sections["SECTIONS"] -= 243;

                for (int i = 1; i <= numSections; i++)
                {
                    Label sectionLabelLabel = (Label)Controls.Find("section" + i + "LabelLabel", true)[0];
                    sectionLabelLabel.Enabled = false;
                    TextBox sectionLabelEnter = (TextBox)Controls.Find("section" + i + "LabelEnter", true)[0];
                    sectionLabelEnter.Enabled = false;
                }

                addSpace("sectionsDefaultButton", -243, "sectionsPanel", "SECTIONS");
                sectionLabelGroupBox.Height = 45;
                sectionLabelLocationGroupBox.Visible = false;
                sectionLabelStyleGroupBox.Visible = false;
            }
            subsectionLabelGroupBox.Location = new Point(9, sectionLabelGroupBox.Location.Y + sectionLabelGroupBox.Height + 13);
            subsubsectionLabelGroupBox.Location = new Point(9, subsectionLabelGroupBox.Location.Y + subsectionLabelGroupBox.Height + 13);
        }

        private void includeSubsectionLabelCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (includeSubsectionLabelCheck.Checked)
            {
                addSpace("sectionsDefaultButton", 243, "sectionsPanel", "SECTIONS");
                subsectionLabelGroupBox.Height = 288;
                subsectionLabelLocationGroupBox.Visible = true;
                subsectionLabelStyleGroupBox.Visible = true;
                for (int i = 1; i <= contentSections.Count; i++)
                {
                    for (int j = 1; j <= contentSections[i - 1].subSections.Count; j++)
                    {
                        Label subsectionLabelLabel = (Label)Controls.Find("section" + i + "Subsection" + j + "LabelLabel", true)[0];
                        subsectionLabelLabel.Enabled = true;
                        TextBox subsectionLabelTextBox = (TextBox)Controls.Find("section" + i + "Subsection" + j + "LabelEnter", true)[0];
                        subsectionLabelTextBox.Enabled = true;
                    }
                }
            }
            else
            {
                addSpace("sectionsDefaultButton", -243, "sectionsPanel", "SECTIONS");
                subsectionLabelGroupBox.Height = 45;
                subsectionLabelLocationGroupBox.Visible = false;
                subsectionLabelStyleGroupBox.Visible = false;
                for (int i = 1; i <= contentSections.Count; i++)
                {
                    for (int j = 1; j <= contentSections[i - 1].subSections.Count; j++)
                    {
                        Label subsectionLabelLabel = (Label)Controls.Find("section" + i + "Subsection" + j + "LabelLabel", true)[0];
                        subsectionLabelLabel.Enabled = false;
                        TextBox subsectionLabelTextBox = (TextBox)Controls.Find("section" + i + "Subsection" + j + "LabelEnter", true)[0];
                        subsectionLabelTextBox.Enabled = false;
                    }
                }
            }
            subsubsectionLabelGroupBox.Location = new Point(9, subsectionLabelGroupBox.Location.Y + subsectionLabelGroupBox.Height + 13);
        }

        private void includeSubsubsectionLabelCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (includeSubsubsectionLabelCheck.Checked)
            {
                addSpace("sectionsDefaultButton", 243, "sectionsPanel", "SECTIONS");
                subsubsectionLabelGroupBox.Height = 288;
                subsubsectionLabelLocationGroupBox.Visible = true;
                subsubsectionLabelStyleGroupBox.Visible = true;
                for (int i = 1; i <= contentSections.Count; i++)
                {
                    for (int j = 1; j <= contentSections[i - 1].subSections.Count; j++)
                    {
                        for (int k = 1; k <= contentSections[i - 1].subSections[j - 1].subsubSections.Count; k++)
                        {
                            Label subsubsectionLabelLabel = (Label)Controls.Find("section" + i + "Subsection" + j + "Subsubsection" + k + "LabelLabel", true)[0];
                            subsubsectionLabelLabel.Enabled = true;
                            TextBox subsubsectionLabelTextBox = (TextBox)Controls.Find("section" + i + "Subsection" + j + "Subsubsection" + k + "LabelEnter", true)[0];
                            subsubsectionLabelTextBox.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                addSpace("sectionsDefaultButton", -243, "sectionsPanel", "SECTIONS");
                subsubsectionLabelGroupBox.Height = 45;
                subsubsectionLabelLocationGroupBox.Visible = false;
                subsubsectionLabelStyleGroupBox.Visible = false;
                for (int i = 1; i <= contentSections.Count; i++)
                {
                    for (int j = 1; j <= contentSections[i - 1].subSections.Count; j++)
                    {
                        for (int k = 1; k <= contentSections[i - 1].subSections[j - 1].subsubSections.Count; k++)
                        {
                            Label subsubsectionLabelLabel = (Label)Controls.Find("section" + i + "Subsection" + j + "Subsubsection" + k + "LabelLabel", true)[0];
                            subsubsectionLabelLabel.Enabled = false;
                            TextBox subsubsectionLabelTextBox = (TextBox)Controls.Find("section" + i + "Subsection" + j + "Subsubsection" + k + "LabelEnter", true)[0];
                            subsubsectionLabelTextBox.Enabled = false;
                        }
                    }
                }
            }
        }

        private void addSectionButton_Click(object sender, EventArgs e)
        {
            Section newSection = new Section();
            newSection.index = contentSections.Count + 1;
            contentSections.Add(newSection);

            GroupBox newSectionGroupBox = new GroupBox();
            newSectionGroupBox.Name = "section" + newSection.index + "groupBox";
            newSectionGroupBox.Text = "Section " + newSection.index;
            newSectionGroupBox.Font = new Font("Microsoft Sans Serif", (float)9.75, FontStyle.Bold);
            contentPanel.Controls.Add(newSectionGroupBox);

            Label newSectionLabelLabel = new Label();
            newSectionLabelLabel.Name = "section" + newSection.index + "LabelLabel";
            newSectionLabelLabel.Text = "Section Label:";

            TextBox newSectionLabelEnter = new TextBox();
            newSectionLabelEnter.Name = "section" + newSection.index + "LabelEnter";
            newSectionLabelEnter.Size = new Size(185, 20);
            newSectionGroupBox.Controls.Add(newSectionLabelEnter);
            newSectionLabelEnter.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            newSectionLabelEnter.Location = new Point(81, 19);

            if (!includeSectionLabelsCheck.Checked)
            {
                newSectionLabelLabel.Enabled = false;
                newSectionLabelEnter.Enabled = false;
            }

            newSectionGroupBox.Controls.Add(newSectionLabelLabel);
            newSectionLabelLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            newSectionLabelLabel.Location = new Point(6, 22);

            Label newSectionContentLabel = new Label();
            newSectionContentLabel.Name = "section" + newSection.index + "contentLabel";
            newSectionContentLabel.Text = "Content:";
            newSectionGroupBox.Controls.Add(newSectionContentLabel);
            newSectionContentLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);

            Panel newSectionContentPanel = new Panel();
            newSectionContentPanel.Name = "section" + newSection.index + "ContentPanel";
            newSectionGroupBox.Controls.Add(newSectionContentPanel);

            ToolStripContainer newSectionToolStripContainer = new ToolStripContainer();
            newSectionToolStripContainer.Name = "section" + newSection.index + "ToolStripContainer";
            newSectionContentPanel.Controls.Add(newSectionToolStripContainer);

            ToolStrip newSectionToolStrip = new ToolStrip();
            newSectionToolStrip.Name = "section" + newSection.index + "ToolStrip";
            newSectionToolStrip.RenderMode = ToolStripRenderMode.System;
            newSectionToolStrip.Size = new Size(43, 25);
            newSectionToolStripContainer.TopToolStripPanel.Controls.Add(newSectionToolStrip);

            RichTextBox newSectionContent = new RichTextBox();
            newSectionContent.Name = "section" + newSection.index + "Content";
            newSectionToolStripContainer.ContentPanel.Controls.Add(newSectionContent);
            newSectionContent.Location = new Point(0, 0);
            newSectionContent.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);

            Button newSectionAddSubsectionButton = new Button();
            newSectionAddSubsectionButton.Name = "section" + newSection.index + "AddSubsectionButton";
            newSectionAddSubsectionButton.Text = "Add Subsection";
            newSectionAddSubsectionButton.Size = new Size(130, 23);
            newSectionAddSubsectionButton.BackColor = Color.Gainsboro;
            newSectionGroupBox.Controls.Add(newSectionAddSubsectionButton);
            newSectionGroupBox.Controls.Add(newSectionContentLabel);
            newSectionAddSubsectionButton.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            newSectionAddSubsectionButton.Tag = newSection.index;
            newSectionAddSubsectionButton.Click += new EventHandler(sectionAddSubsectionButton_Click);

            addSpace("addSectionButton", 335, "contentPanel", "CONTENT");
            newSectionGroupBox.Size = new Size(615, 315);
            newSectionGroupBox.Location = new Point(9, addSectionButton.Location.Y - 321);
            newSectionLabelLabel.Visible = true;
            newSectionLabelEnter.Visible = true;
            newSectionContentLabel.Location = new Point(6, 49);
            newSectionContentPanel.Size = new Size(newSectionGroupBox.Width - 18, 210);
            newSectionContentPanel.Location = new Point(9, 67);
            newSectionToolStripContainer.Size = newSectionContentPanel.Size;
            newSectionContent.Size = new Size(newSectionToolStripContainer.ContentPanel.Width - 3, newSectionToolStripContainer.ContentPanel.Height - 3);
            newSectionAddSubsectionButton.Location = new Point(9, 282);
            checkContentPanelHeight();
        }

        private void sectionAddSubsectionButton_Click(object sender, EventArgs e)
        {
            if (!subsectionLabelGroupBox.Visible)
            {
                addSpace("sectionsDefaultButton", 56, "sectionsPanel", "SECTIONS");
                subsectionLabelGroupBox.Location = new Point(9, sectionLabelGroupBox.Location.Y + sectionLabelGroupBox.Height + 8);
                subsectionLabelGroupBox.Visible = true;
            }
            SubSection subSectionToAdd = new SubSection();

            int sectionIndex = Convert.ToInt32(((Button)sender).Tag);
            int subsectionIndex = 0;
            foreach (Section section in contentSections)
            {
                if (section.index == sectionIndex)
                {
                    subsectionIndex = section.subSections.Count + 1;
                    subSectionToAdd.index = subsectionIndex;
                    section.subSections.Add(subSectionToAdd);
                }
            }

            GroupBox sectionToAddTo = (GroupBox)Controls.Find("section" + sectionIndex + "groupBox", true)[0];
            Control starter = Controls.Find("section" + sectionIndex + "AddSubsectionButton", true)[0];
            GroupBox subsectionToAdd = new GroupBox();
            subsectionToAdd.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "GroupBox";
            subsectionToAdd.Text = "Subsection " + subsectionIndex;
            sectionToAddTo.Controls.Add(subsectionToAdd);

            Label subsectionLabelLabel = new Label();
            subsectionLabelLabel.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "LabelLabel";
            subsectionLabelLabel.Text = "Subsection Label:";
            subsectionToAdd.Controls.Add(subsectionLabelLabel);
            subsectionLabelLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsectionLabelLabel.Location = new Point(6, 22);

            TextBox subsectionLabelEnter = new TextBox();
            subsectionLabelEnter.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "LabelEnter";
            subsectionToAdd.Controls.Add(subsectionLabelEnter);
            subsectionLabelEnter.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsectionLabelEnter.Location = new Point(110, 19);
            subsectionLabelEnter.Width = 185;

            if (!includeSubsectionLabelCheck.Checked)
            {
                subsectionLabelLabel.Enabled = false;
                subsectionLabelEnter.Enabled = false;
            }

            Label subsectionContentLabel = new Label();
            subsectionContentLabel.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "ContentLabel";
            subsectionContentLabel.Text = "Content:";
            subsectionToAdd.Controls.Add(subsectionContentLabel);
            subsectionContentLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsectionContentLabel.BackColor = Color.Transparent;

            Panel subsectionContentPanel = new Panel();
            subsectionContentPanel.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "ContentPanel";
            subsectionToAdd.Controls.Add(subsectionContentPanel);

            ToolStripContainer subsectionToolStripContainer = new ToolStripContainer();
            subsectionToolStripContainer.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "toolstripcontainer";

            ToolStrip subsectionToolStrip = new ToolStrip();
            subsectionToolStrip.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "toolstrip";
            subsectionToolStrip.RenderMode = ToolStripRenderMode.System;
            subsectionToolStrip.Size = new Size(43, 25);
            subsectionToolStripContainer.TopToolStripPanel.Controls.Add(subsectionToolStrip);
            subsectionContentPanel.Controls.Add(subsectionToolStripContainer);

            RichTextBox subsectionContent = new RichTextBox();
            subsectionContent.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Content";
            subsectionToolStripContainer.ContentPanel.Controls.Add(subsectionContent);
            subsectionContent.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsectionContent.Location = new Point(0, 0);

            Button addSubsubsectionButton = new Button();
            addSubsubsectionButton.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "AddSubsubsectionButton";
            addSubsubsectionButton.Text = "Add Subsubsection";
            addSubsubsectionButton.Size = new Size(130, 23);
            addSubsubsectionButton.BackColor = Color.Gainsboro;
            addSubsubsectionButton.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            addSubsubsectionButton.Tag = sectionIndex + "," + subsectionIndex;
            addSubsubsectionButton.Click += new EventHandler(subsectionAddSubsubsectionButton_Click);

            addSpace("section" + sectionIndex + "AddSubsectionButton", 315, "contentPanel", "CONTENT");
            subsectionToAdd.Location = new Point(9, starter.Location.Y - 310);
            subsectionToAdd.Size = new Size(sectionToAddTo.Width - 18, 305);
            subsectionToAdd.Font = new Font(subsectionToAdd.Font, FontStyle.Regular);
            subsectionContentLabel.Location = new Point(6, 49);
            subsectionContentPanel.Location = new Point(9, 73);
            subsectionContentPanel.Size = new Size(subsectionToAdd.Width - 18, 189);
            subsectionToolStripContainer.Size = subsectionContentPanel.Size;
            subsectionContent.Size = new Size(subsectionToolStripContainer.ContentPanel.Width - 3, subsectionToolStripContainer.ContentPanel.Height - 3);
            subsectionToAdd.Controls.Add(addSubsubsectionButton);
            addSubsubsectionButton.Location = new Point(9, 272);
            checkContentPanelHeight();
        }

        private void subsectionAddSubsubsectionButton_Click(object sender, EventArgs e)
        {
            if (!subsubsectionLabelGroupBox.Visible)
            {
                addSpace("sectionsDefaultButton", 56, "sectionsPanel", "SECTIONS");
                subsubsectionLabelGroupBox.Location = new Point(9, subsectionLabelGroupBox.Location.Y + subsectionLabelGroupBox.Height + 8);
                subsubsectionLabelGroupBox.Visible = true;
            }
            SubSubSection subsubSectionToAdd = new SubSubSection();

            string tag = (string)((Button)sender).Tag;
            string[] indexes = tag.Split(',');

            int sectionIndex = Convert.ToInt32(indexes[0]);
            int subsectionIndex = Convert.ToInt32(indexes[1]);
            int subsubsectionIndex = 0;
            foreach (Section section in contentSections)
            {
                if (section.index == sectionIndex)
                {
                    foreach (SubSection subsection in section.subSections)
                    {
                        if (subsection.index == subsectionIndex)
                        {
                            subsubsectionIndex = subsection.subsubSections.Count + 1;
                            subsubSectionToAdd.index = subsubsectionIndex;
                            subsection.subsubSections.Add(subsubSectionToAdd);
                        }
                    }
                }
            }

            GroupBox subsectionToAddTo = (GroupBox)Controls.Find("section" + sectionIndex + "Subsection" + subsectionIndex + "GroupBox", true)[0];
            Control starter = Controls.Find("section" + sectionIndex + "Subsection" + subsectionIndex + "AddSubsubsectionButton", true)[0];
            GroupBox subsubsectionToAdd = new GroupBox();
            subsubsectionToAdd.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "GroupBox";
            subsubsectionToAdd.Text = "Subsubsection " + subsubsectionIndex;
            subsectionToAddTo.Controls.Add(subsubsectionToAdd);

            Label subsubsectionLabelLabel = new Label();
            subsubsectionLabelLabel.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "LabelLabel";
            subsubsectionLabelLabel.Text = "Subsubsection Label:";
            subsubsectionToAdd.Controls.Add(subsubsectionLabelLabel);
            subsubsectionLabelLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsubsectionLabelLabel.Location = new Point(6, 22);
            subsubsectionLabelLabel.Size = new Size(110, 13);

            TextBox subsubsectionLabelEnter = new TextBox();
            subsubsectionLabelEnter.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "LabelEnter";
            subsubsectionToAdd.Controls.Add(subsubsectionLabelEnter);
            subsubsectionLabelEnter.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsubsectionLabelEnter.Location = new Point(122, 19);
            subsubsectionLabelEnter.Width = 185;

            if (!includeSubsubsectionLabelCheck.Checked)
            {
                subsubsectionLabelLabel.Enabled = false;
                subsubsectionLabelEnter.Enabled = false;
            }

            Label subsubsectionContentLabel = new Label();
            subsubsectionContentLabel.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "ContentLabel";
            subsubsectionContentLabel.Text = "Content:";
            subsubsectionToAdd.Controls.Add(subsubsectionContentLabel);
            subsubsectionContentLabel.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsubsectionContentLabel.BackColor = Color.Transparent;

            Panel subsubsectionContentPanel = new Panel();
            subsubsectionContentPanel.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "ContentPanel";
            subsubsectionToAdd.Controls.Add(subsubsectionContentPanel);

            ToolStripContainer subsubsectionToolStripContainer = new ToolStripContainer();
            subsubsectionToolStripContainer.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "toolstripcontainer";

            ToolStrip subsubsectionToolStrip = new ToolStrip();
            subsubsectionToolStrip.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "toolstrip";
            subsubsectionToolStrip.RenderMode = ToolStripRenderMode.System;
            subsubsectionToolStrip.Size = new Size(43, 25);
            subsubsectionToolStripContainer.TopToolStripPanel.Controls.Add(subsubsectionToolStrip);
            subsubsectionContentPanel.Controls.Add(subsubsectionToolStripContainer);

            RichTextBox subsubsectionContent = new RichTextBox();
            subsubsectionContent.Name = "section" + sectionIndex + "Subsection" + subsectionIndex + "Subsubsection" + subsubsectionIndex + "Content";
            subsubsectionToolStripContainer.ContentPanel.Controls.Add(subsubsectionContent);
            subsubsectionContent.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);
            subsubsectionContent.Location = new Point(0, 0);

            addSpace("section" + sectionIndex + "Subsection" + subsubsectionIndex + "AddSubsubsectionButton", 282, "contentPanel", "CONTENT");
            subsubsectionToAdd.Location = new Point(9, starter.Location.Y - 277);
            subsubsectionToAdd.Size = new Size(subsectionToAddTo.Width - 18, 272);
            subsubsectionToAdd.Font = new Font(subsubsectionToAdd.Font, FontStyle.Regular);
            subsubsectionContentLabel.Location = new Point(6, 49);
            subsubsectionContentPanel.Location = new Point(9, 73);
            subsubsectionContentPanel.Size = new Size(subsubsectionToAdd.Width - 18, 189);
            subsubsectionToolStripContainer.Size = subsubsectionContentPanel.Size;
            subsubsectionContent.Size = new Size(subsubsectionToolStripContainer.ContentPanel.Width - 3, subsubsectionToolStripContainer.ContentPanel.Height - 3);
            checkContentPanelHeight();

            Console.WriteLine(subsubsectionLabelLabel.Text);
        }
    }
}
