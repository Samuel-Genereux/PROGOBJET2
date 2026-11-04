#nullable enable
namespace S10E01_Facturation.WinForms;

partial class FormCommande
{
    private System.ComponentModel.IContainer? m_components;
    private TableLayoutPanel m_principal = null!;
    private FlowLayoutPanel m_entete = null!;
    private FlowLayoutPanel m_saisie = null!;
    private FlowLayoutPanel m_pied = null!;
    private Button m_nouvelle = null!;
    private Label m_labelNumero = null!;
    private Label m_labelQuantite = null!;

    private Label m_titreCourant = null!;
    private TextBox m_numero = null!;
    private TextBox m_quantite = null!;
    private ListBox m_listeProduits = null!;
    private DataGridView m_grille = null!;
    private Button m_ajouter = null!;
    private Button m_enregistrer = null!;
    private Label m_total = null!;
    private Label m_etat = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && m_components is not null)
        {
            m_components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        m_principal = new TableLayoutPanel();
        m_entete = new FlowLayoutPanel();
        m_labelNumero = new Label();
        m_numero = new TextBox();
        m_nouvelle = new Button();
        m_titreCourant = new Label();
        m_saisie = new FlowLayoutPanel();
        m_listeProduits = new ListBox();
        m_labelQuantite = new Label();
        m_quantite = new TextBox();
        m_ajouter = new Button();
        m_grille = new DataGridView();
        m_pied = new FlowLayoutPanel();
        m_total = new Label();
        m_enregistrer = new Button();
        m_etat = new Label();
        m_principal.SuspendLayout();
        m_entete.SuspendLayout();
        m_saisie.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)m_grille).BeginInit();
        m_pied.SuspendLayout();
        SuspendLayout();
        // 
        // m_principal
        // 
        m_principal.ColumnCount = 1;
        m_principal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        m_principal.Controls.Add(m_entete, 0, 0);
        m_principal.Controls.Add(m_titreCourant, 0, 1);
        m_principal.Controls.Add(m_saisie, 0, 2);
        m_principal.Controls.Add(m_grille, 0, 3);
        m_principal.Controls.Add(m_pied, 0, 4);
        m_principal.Controls.Add(m_etat, 0, 5);
        m_principal.Dock = DockStyle.Fill;
        m_principal.Location = new Point(0, 0);
        m_principal.Name = "m_principal";
        m_principal.Padding = new Padding(16);
        m_principal.RowCount = 6;
        m_principal.RowStyles.Add(new RowStyle());
        m_principal.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        m_principal.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
        m_principal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        m_principal.RowStyles.Add(new RowStyle());
        m_principal.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        m_principal.Size = new Size(900, 650);
        m_principal.TabIndex = 0;
        // 
        // m_entete
        // 
        m_entete.AutoSize = true;
        m_entete.Controls.Add(m_labelNumero);
        m_entete.Controls.Add(m_numero);
        m_entete.Controls.Add(m_nouvelle);
        m_entete.Dock = DockStyle.Fill;
        m_entete.Location = new Point(19, 19);
        m_entete.Name = "m_entete";
        m_entete.Size = new Size(862, 36);
        m_entete.TabIndex = 0;
        // 
        // m_labelNumero
        // 
        m_labelNumero.AutoSize = true;
        m_labelNumero.Location = new Point(3, 0);
        m_labelNumero.Name = "m_labelNumero";
        m_labelNumero.Size = new Size(239, 20);
        m_labelNumero.TabIndex = 0;
        m_labelNumero.Text = "Numéro de la nouvelle commande";
        // 
        // m_numero
        // 
        m_numero.AccessibleName = "Numéro proposé pour une nouvelle commande";
        m_numero.Location = new Point(248, 3);
        m_numero.Name = "m_numero";
        m_numero.Size = new Size(80, 27);
        m_numero.TabIndex = 0;
        m_numero.Text = "1";
        // 
        // m_nouvelle
        // 
        m_nouvelle.AutoSize = true;
        m_nouvelle.Location = new Point(334, 3);
        m_nouvelle.Name = "m_nouvelle";
        m_nouvelle.Size = new Size(78, 30);
        m_nouvelle.TabIndex = 1;
        m_nouvelle.Text = "&Nouvelle";
        m_nouvelle.Click += Nouvelle_Click;
        // 
        // m_titreCourant
        // 
        m_titreCourant.AutoSize = true;
        m_titreCourant.Dock = DockStyle.Fill;
        m_titreCourant.Location = new Point(19, 58);
        m_titreCourant.Name = "m_titreCourant";
        m_titreCourant.Size = new Size(862, 40);
        m_titreCourant.TabIndex = 1;
        // 
        // m_saisie
        // 
        m_saisie.AutoScroll = true;
        m_saisie.Controls.Add(m_listeProduits);
        m_saisie.Controls.Add(m_labelQuantite);
        m_saisie.Controls.Add(m_quantite);
        m_saisie.Controls.Add(m_ajouter);
        m_saisie.Dock = DockStyle.Fill;
        m_saisie.Location = new Point(19, 101);
        m_saisie.Name = "m_saisie";
        m_saisie.Size = new Size(862, 104);
        m_saisie.TabIndex = 2;
        // 
        // m_listeProduits
        // 
        m_listeProduits.AccessibleName = "Produit à ajouter";
        m_listeProduits.Location = new Point(3, 3);
        m_listeProduits.Name = "m_listeProduits";
        m_listeProduits.Size = new Size(220, 84);
        m_listeProduits.TabIndex = 0;
        // 
        // m_labelQuantite
        // 
        m_labelQuantite.AutoSize = true;
        m_labelQuantite.Location = new Point(229, 0);
        m_labelQuantite.Name = "m_labelQuantite";
        m_labelQuantite.Size = new Size(66, 20);
        m_labelQuantite.TabIndex = 1;
        m_labelQuantite.Text = "Quantité";
        // 
        // m_quantite
        // 
        m_quantite.AccessibleName = "Quantité à ajouter";
        m_quantite.Location = new Point(301, 3);
        m_quantite.Name = "m_quantite";
        m_quantite.Size = new Size(70, 27);
        m_quantite.TabIndex = 1;
        m_quantite.Text = "1";
        // 
        // m_ajouter
        // 
        m_ajouter.AutoSize = true;
        m_ajouter.Location = new Point(377, 3);
        m_ajouter.Name = "m_ajouter";
        m_ajouter.Size = new Size(75, 30);
        m_ajouter.TabIndex = 2;
        m_ajouter.Text = "&Ajouter";
        m_ajouter.Click += Ajouter_Click;
        // 
        // m_grille
        // 
        m_grille.AccessibleName = "Lignes de la commande courante";
        m_grille.AllowUserToAddRows = false;
        m_grille.AllowUserToDeleteRows = false;
        m_grille.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        m_grille.ColumnHeadersHeight = 29;
        m_grille.Dock = DockStyle.Fill;
        m_grille.Location = new Point(19, 211);
        m_grille.Name = "m_grille";
        m_grille.ReadOnly = true;
        m_grille.RowHeadersWidth = 51;
        m_grille.Size = new Size(862, 322);
        m_grille.TabIndex = 3;
        // 
        // m_pied
        // 
        m_pied.AutoSize = true;
        m_pied.Controls.Add(m_total);
        m_pied.Controls.Add(m_enregistrer);
        m_pied.Dock = DockStyle.Fill;
        m_pied.Location = new Point(19, 539);
        m_pied.Name = "m_pied";
        m_pied.Size = new Size(862, 36);
        m_pied.TabIndex = 4;
        // 
        // m_total
        // 
        m_total.AutoSize = true;
        m_total.Location = new Point(3, 9);
        m_total.Margin = new Padding(3, 9, 24, 3);
        m_total.Name = "m_total";
        m_total.Size = new Size(0, 20);
        m_total.TabIndex = 0;
        // 
        // m_enregistrer
        // 
        m_enregistrer.AutoSize = true;
        m_enregistrer.Location = new Point(30, 3);
        m_enregistrer.Name = "m_enregistrer";
        m_enregistrer.Size = new Size(90, 30);
        m_enregistrer.TabIndex = 0;
        m_enregistrer.Text = "&Enregistrer";
        m_enregistrer.Click += Enregistrer_Click;
        // 
        // m_etat
        // 
        m_etat.AccessibleName = "État de la commande";
        m_etat.Dock = DockStyle.Fill;
        m_etat.Location = new Point(19, 578);
        m_etat.Name = "m_etat";
        m_etat.Size = new Size(862, 56);
        m_etat.TabIndex = 5;
        // 
        // FormCommande
        // 
        AcceptButton = m_ajouter;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 650);
        Controls.Add(m_principal);
        MinimumSize = new Size(800, 550);
        Name = "FormCommande";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Prise de commande";
        FormClosing += FormCommande_FormClosing;
        m_principal.ResumeLayout(false);
        m_principal.PerformLayout();
        m_entete.ResumeLayout(false);
        m_entete.PerformLayout();
        m_saisie.ResumeLayout(false);
        m_saisie.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)m_grille).EndInit();
        m_pied.ResumeLayout(false);
        m_pied.PerformLayout();
        ResumeLayout(false);
    }
}
