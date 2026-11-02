#nullable disable
namespace Contacts.WinForms;

partial class FormContacts
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        lNom = new Label();
        lCourriel = new Label();
        tbNom = new TextBox();
        tbCourriel = new TextBox();
        bCreer = new Button();
        bEffacer = new Button();
        lEtat = new Label();
        lMotClef = new Label();
        tbMotClef = new TextBox();
        bRechercher = new Button();
        bTous = new Button();
        dgvContacts = new DataGridView();
        colNom = new DataGridViewTextBoxColumn();
        colCourriel = new DataGridViewTextBoxColumn();
        lNombre = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
        SuspendLayout();
        // 
        // lNom
        // 
        lNom.AutoSize = true;
        lNom.Location = new Point(31, 37);
        lNom.Name = "lNom";
        lNom.Size = new Size(42, 20);
        lNom.TabIndex = 0;
        lNom.Text = "Nom";
        lNom.Click += label1_Click;
        // 
        // lCourriel
        // 
        lCourriel.AutoSize = true;
        lCourriel.Location = new Point(31, 97);
        lCourriel.Name = "lCourriel";
        lCourriel.Size = new Size(61, 20);
        lCourriel.TabIndex = 1;
        lCourriel.Text = "Courriel";
        // 
        // tbNom
        // 
        tbNom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tbNom.Location = new Point(106, 37);
        tbNom.Name = "tbNom";
        tbNom.Size = new Size(669, 27);
        tbNom.TabIndex = 0;
        // 
        // tbCourriel
        // 
        tbCourriel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tbCourriel.Location = new Point(106, 97);
        tbCourriel.Name = "tbCourriel";
        tbCourriel.Size = new Size(669, 27);
        tbCourriel.TabIndex = 1;
        // 
        // bCreer
        // 
        bCreer.BackColor = SystemColors.ActiveCaption;
        bCreer.Location = new Point(106, 154);
        bCreer.Name = "bCreer";
        bCreer.Size = new Size(115, 38);
        bCreer.TabIndex = 2;
        bCreer.Text = "Créer";
        bCreer.UseVisualStyleBackColor = false;
        bCreer.Click += bCreer_Click;
        // 
        // bEffacer
        // 
        bEffacer.BackColor = SystemColors.ActiveCaption;
        bEffacer.Location = new Point(253, 154);
        bEffacer.Name = "bEffacer";
        bEffacer.Size = new Size(114, 38);
        bEffacer.TabIndex = 3;
        bEffacer.Text = "Effacer";
        bEffacer.UseVisualStyleBackColor = false;
        bEffacer.Click += bEffacer_Click;
        // 
        // lEtat
        // 
        lEtat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lEtat.AutoSize = true;
        lEtat.Location = new Point(12, 496);
        lEtat.Name = "lEtat";
        lEtat.Size = new Size(139, 20);
        lEtat.TabIndex = 4;
        lEtat.Text = "Etat de l'opération :";
        // 
        // lMotClef
        // 
        lMotClef.AutoSize = true;
        lMotClef.Location = new Point(24, 234);
        lMotClef.Name = "lMotClef";
        lMotClef.Size = new Size(68, 20);
        lMotClef.TabIndex = 5;
        lMotClef.Text = "Mot-Clef";
        lMotClef.Click += label1_Click_1;
        // 
        // tbMotClef
        // 
        tbMotClef.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tbMotClef.Location = new Point(124, 234);
        tbMotClef.Name = "tbMotClef";
        tbMotClef.Size = new Size(357, 27);
        tbMotClef.TabIndex = 6;
        // 
        // bRechercher
        // 
        bRechercher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        bRechercher.BackColor = SystemColors.ActiveCaption;
        bRechercher.Location = new Point(523, 234);
        bRechercher.Name = "bRechercher";
        bRechercher.Size = new Size(115, 38);
        bRechercher.TabIndex = 7;
        bRechercher.Text = "Rechercher";
        bRechercher.UseVisualStyleBackColor = false;
        bRechercher.Click += bRechercher_Click;
        // 
        // bTous
        // 
        bTous.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        bTous.BackColor = SystemColors.ActiveCaption;
        bTous.Location = new Point(670, 234);
        bTous.Name = "bTous";
        bTous.Size = new Size(115, 38);
        bTous.TabIndex = 8;
        bTous.Text = "Tous";
        bTous.UseVisualStyleBackColor = false;
        bTous.Click += bTous_Click;
        // 
        // dgvContacts
        // 
        dgvContacts.AllowUserToAddRows = false;
        dgvContacts.AllowUserToDeleteRows = false;
        dgvContacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvContacts.BackgroundColor = SystemColors.Control;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvContacts.ColumnHeadersHeight = 30;
        dgvContacts.Columns.AddRange(new DataGridViewColumn[] { colNom, colCourriel });
        dgvContacts.EnableHeadersVisualStyles = false;
        dgvContacts.Location = new Point(106, 278);
        dgvContacts.Name = "dgvContacts";
        dgvContacts.RowHeadersVisible = false;
        dgvContacts.RowHeadersWidth = 51;
        dgvContacts.Size = new Size(619, 171);
        dgvContacts.TabIndex = 9;
        // 
        // colNom
        // 
        colNom.DataPropertyName = "Nom";
        colNom.HeaderText = "Nom";
        colNom.MinimumWidth = 6;
        colNom.Name = "colNom";
        colNom.ReadOnly = true;
        // 
        // colCourriel
        // 
        colCourriel.DataPropertyName = "Courriel";
        colCourriel.HeaderText = "Courriel";
        colCourriel.MinimumWidth = 6;
        colCourriel.Name = "colCourriel";
        // 
        // lNombre
        // 
        lNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lNombre.AutoSize = true;
        lNombre.Location = new Point(12, 467);
        lNombre.Name = "lNombre";
        lNombre.Size = new Size(78, 20);
        lNombre.TabIndex = 10;
        lNombre.Text = "0 Contacts";
        // 
        // FormContacts
        // 
        AcceptButton = bCreer;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(809, 548);
        Controls.Add(lNombre);
        Controls.Add(dgvContacts);
        Controls.Add(bTous);
        Controls.Add(bRechercher);
        Controls.Add(tbMotClef);
        Controls.Add(lMotClef);
        Controls.Add(lEtat);
        Controls.Add(bEffacer);
        Controls.Add(bCreer);
        Controls.Add(tbCourriel);
        Controls.Add(tbNom);
        Controls.Add(lCourriel);
        Controls.Add(lNom);
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(797, 584);
        Name = "FormContacts";
        Text = "Fiche de contact — à construire";
        Load += FormContacts_Load;
        ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
        ResumeLayout(false);
        PerformLayout();
        // Construire les contrôles dans le designer et relier chaque Click une seule fois.
    }

    private Label lNom;
    private Label lCourriel;
    private TextBox tbNom;
    private TextBox tbCourriel;
    private Button bCreer;
    private Button bEffacer;
    private Label lEtat;
    private Label lMotClef;
    private TextBox tbMotClef;
    private Button bRechercher;
    private Button bTous;
    private DataGridView dgvContacts;
    private Label lNombre;
    private DataGridViewTextBoxColumn colNom;
    private DataGridViewTextBoxColumn colCourriel;
}
