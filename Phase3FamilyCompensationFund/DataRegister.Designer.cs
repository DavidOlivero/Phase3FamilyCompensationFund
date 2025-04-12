using System.ComponentModel;

namespace Phase3FamilyCompensationFund;

partial class DataRegister
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        GbAffiliateData = new System.Windows.Forms.GroupBox();
        label12 = new System.Windows.Forms.Label();
        BtnClose = new System.Windows.Forms.Button();
        BtnClear = new System.Windows.Forms.Button();
        BtnRegister = new System.Windows.Forms.Button();
        DpDate = new System.Windows.Forms.DateTimePicker();
        GbSisbenAffiliate = new System.Windows.Forms.GroupBox();
        CkbNo = new System.Windows.Forms.RadioButton();
        CkbYes = new System.Windows.Forms.RadioButton();
        TbDataReport = new System.Windows.Forms.TextBox();
        LblDataReport = new System.Windows.Forms.Label();
        TbSubsidyValue = new System.Windows.Forms.TextBox();
        LblSubsidyValue = new System.Windows.Forms.Label();
        LbDate = new System.Windows.Forms.Label();
        TbSalary = new System.Windows.Forms.TextBox();
        LblSalary = new System.Windows.Forms.Label();
        TbIdNumber = new System.Windows.Forms.TextBox();
        LblIdNumber = new System.Windows.Forms.Label();
        TbFullName = new System.Windows.Forms.TextBox();
        LblFullName = new System.Windows.Forms.Label();
        SldStructureType = new System.Windows.Forms.ComboBox();
        LblStructureType = new System.Windows.Forms.Label();
        SldStratum = new System.Windows.Forms.ComboBox();
        LblStratum = new System.Windows.Forms.Label();
        SldIdType = new System.Windows.Forms.ComboBox();
        LblIdType = new System.Windows.Forms.Label();
        tail = new System.Windows.Forms.TabPage();
        DgvQueue = new System.Windows.Forms.DataGridView();
        dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        BtnQueueDelete = new System.Windows.Forms.Button();
        BtnQueueReport = new System.Windows.Forms.Button();
        stack = new System.Windows.Forms.TabPage();
        DgvStack = new System.Windows.Forms.DataGridView();
        id = new System.Windows.Forms.DataGridViewTextBoxColumn();
        idType = new System.Windows.Forms.DataGridViewTextBoxColumn();
        name = new System.Windows.Forms.DataGridViewTextBoxColumn();
        strate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
        value = new System.Windows.Forms.DataGridViewTextBoxColumn();
        BtnStackDelete = new System.Windows.Forms.Button();
        BtnStackReport = new System.Windows.Forms.Button();
        tabControl1 = new System.Windows.Forms.TabControl();
        list = new System.Windows.Forms.TabPage();
        DgvList = new System.Windows.Forms.DataGridView();
        dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        BtnListDelete = new System.Windows.Forms.Button();
        BtnListReport = new System.Windows.Forms.Button();
        GbAffiliateData.SuspendLayout();
        GbSisbenAffiliate.SuspendLayout();
        tail.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DgvQueue).BeginInit();
        stack.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DgvStack).BeginInit();
        tabControl1.SuspendLayout();
        list.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DgvList).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(114, 10);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(581, 30);
        label1.TabIndex = 0;
        label1.Text = "SISTEMA DE VALIDACIÓN DE SUBSIDIO PARA AFILIADOS";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(348, 58);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(129, 25);
        label2.TabIndex = 1;
        label2.Text = "Subsidiar S.A";
        // 
        // GbAffiliateData
        // 
        GbAffiliateData.Controls.Add(label12);
        GbAffiliateData.Controls.Add(BtnClose);
        GbAffiliateData.Controls.Add(BtnClear);
        GbAffiliateData.Controls.Add(BtnRegister);
        GbAffiliateData.Controls.Add(DpDate);
        GbAffiliateData.Controls.Add(GbSisbenAffiliate);
        GbAffiliateData.Controls.Add(TbDataReport);
        GbAffiliateData.Controls.Add(LblDataReport);
        GbAffiliateData.Controls.Add(TbSubsidyValue);
        GbAffiliateData.Controls.Add(LblSubsidyValue);
        GbAffiliateData.Controls.Add(LbDate);
        GbAffiliateData.Controls.Add(TbSalary);
        GbAffiliateData.Controls.Add(LblSalary);
        GbAffiliateData.Controls.Add(TbIdNumber);
        GbAffiliateData.Controls.Add(LblIdNumber);
        GbAffiliateData.Controls.Add(TbFullName);
        GbAffiliateData.Controls.Add(LblFullName);
        GbAffiliateData.Controls.Add(SldStructureType);
        GbAffiliateData.Controls.Add(LblStructureType);
        GbAffiliateData.Controls.Add(SldStratum);
        GbAffiliateData.Controls.Add(LblStratum);
        GbAffiliateData.Controls.Add(SldIdType);
        GbAffiliateData.Controls.Add(LblIdType);
        GbAffiliateData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        GbAffiliateData.Location = new System.Drawing.Point(29, 105);
        GbAffiliateData.Name = "GbAffiliateData";
        GbAffiliateData.Size = new System.Drawing.Size(788, 400);
        GbAffiliateData.TabIndex = 2;
        GbAffiliateData.TabStop = false;
        GbAffiliateData.Text = "Datos del afiliado";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.ForeColor = System.Drawing.Color.Red;
        label12.Location = new System.Drawing.Point(465, 370);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(294, 17);
        label12.TabIndex = 6;
        label12.Text = "Los campos marcados con (*) son obligatorios";
        // 
        // BtnClose
        // 
        BtnClose.Location = new System.Drawing.Point(660, 294);
        BtnClose.Name = "BtnClose";
        BtnClose.Size = new System.Drawing.Size(122, 31);
        BtnClose.TabIndex = 5;
        BtnClose.Text = "Salir";
        BtnClose.UseVisualStyleBackColor = true;
        BtnClose.Click += BtnClose_Click;
        // 
        // BtnClear
        // 
        BtnClear.Location = new System.Drawing.Point(527, 294);
        BtnClear.Name = "BtnClear";
        BtnClear.Size = new System.Drawing.Size(122, 31);
        BtnClear.TabIndex = 5;
        BtnClear.Text = "Limpiar";
        BtnClear.UseVisualStyleBackColor = true;
        BtnClear.Click += BtnClear_Click;
        // 
        // BtnRegister
        // 
        BtnRegister.Location = new System.Drawing.Point(387, 294);
        BtnRegister.Name = "BtnRegister";
        BtnRegister.Size = new System.Drawing.Size(122, 31);
        BtnRegister.TabIndex = 5;
        BtnRegister.Text = "Registrar";
        BtnRegister.UseVisualStyleBackColor = true;
        BtnRegister.Click += BtnRegister_Click;
        // 
        // DpDate
        // 
        DpDate.Location = new System.Drawing.Point(578, 237);
        DpDate.Name = "DpDate";
        DpDate.Size = new System.Drawing.Size(178, 25);
        DpDate.TabIndex = 4;
        // 
        // GbSisbenAffiliate
        // 
        GbSisbenAffiliate.Controls.Add(CkbNo);
        GbSisbenAffiliate.Controls.Add(CkbYes);
        GbSisbenAffiliate.Location = new System.Drawing.Point(443, 138);
        GbSisbenAffiliate.Name = "GbSisbenAffiliate";
        GbSisbenAffiliate.Size = new System.Drawing.Size(316, 68);
        GbSisbenAffiliate.TabIndex = 3;
        GbSisbenAffiliate.TabStop = false;
        GbSisbenAffiliate.Text = "*¿Afiliado a SISBEN?";
        // 
        // CkbNo
        // 
        CkbNo.AutoSize = true;
        CkbNo.Location = new System.Drawing.Point(181, 24);
        CkbNo.Name = "CkbNo";
        CkbNo.Size = new System.Drawing.Size(44, 21);
        CkbNo.TabIndex = 0;
        CkbNo.Text = "No";
        CkbNo.UseVisualStyleBackColor = true;
        CkbNo.CheckedChanged += CkbAny_CheckedChanged;
        // 
        // CkbYes
        // 
        CkbYes.AutoSize = true;
        CkbYes.Checked = true;
        CkbYes.Location = new System.Drawing.Point(96, 24);
        CkbYes.Name = "CkbYes";
        CkbYes.Size = new System.Drawing.Size(37, 21);
        CkbYes.TabIndex = 0;
        CkbYes.TabStop = true;
        CkbYes.Text = "Si";
        CkbYes.UseVisualStyleBackColor = true;
        CkbYes.CheckedChanged += CkbAny_CheckedChanged;
        // 
        // TbDataReport
        // 
        TbDataReport.Enabled = false;
        TbDataReport.Location = new System.Drawing.Point(185, 291);
        TbDataReport.Name = "TbDataReport";
        TbDataReport.Size = new System.Drawing.Size(152, 25);
        TbDataReport.TabIndex = 2;
        // 
        // LblDataReport
        // 
        LblDataReport.AutoSize = true;
        LblDataReport.Location = new System.Drawing.Point(21, 294);
        LblDataReport.Name = "LblDataReport";
        LblDataReport.Size = new System.Drawing.Size(113, 17);
        LblDataReport.TabIndex = 0;
        LblDataReport.Text = "Reporte de datos";
        // 
        // TbSubsidyValue
        // 
        TbSubsidyValue.Enabled = false;
        TbSubsidyValue.Location = new System.Drawing.Point(185, 186);
        TbSubsidyValue.Name = "TbSubsidyValue";
        TbSubsidyValue.Size = new System.Drawing.Size(152, 25);
        TbSubsidyValue.TabIndex = 2;
        // 
        // LblSubsidyValue
        // 
        LblSubsidyValue.AutoSize = true;
        LblSubsidyValue.Location = new System.Drawing.Point(21, 189);
        LblSubsidyValue.Name = "LblSubsidyValue";
        LblSubsidyValue.Size = new System.Drawing.Size(140, 17);
        LblSubsidyValue.TabIndex = 0;
        LblSubsidyValue.Text = "Valor del subsidio ($)";
        // 
        // LbDate
        // 
        LbDate.AutoSize = true;
        LbDate.Location = new System.Drawing.Point(443, 242);
        LbDate.Name = "LbDate";
        LbDate.Size = new System.Drawing.Size(129, 17);
        LbDate.TabIndex = 0;
        LbDate.Text = "*Fecha de afiliación";
        // 
        // TbSalary
        // 
        TbSalary.Location = new System.Drawing.Point(607, 78);
        TbSalary.Name = "TbSalary";
        TbSalary.Size = new System.Drawing.Size(152, 25);
        TbSalary.TabIndex = 2;
        TbSalary.TextChanged += TbSalary_TextChanged;
        TbSalary.KeyPress += TbSalary_KeyPress;
        // 
        // LblSalary
        // 
        LblSalary.AutoSize = true;
        LblSalary.Location = new System.Drawing.Point(443, 81);
        LblSalary.Name = "LblSalary";
        LblSalary.Size = new System.Drawing.Size(77, 17);
        LblSalary.TabIndex = 0;
        LblSalary.Text = "*Salario ($)";
        // 
        // TbIdNumber
        // 
        TbIdNumber.Location = new System.Drawing.Point(607, 30);
        TbIdNumber.Name = "TbIdNumber";
        TbIdNumber.Size = new System.Drawing.Size(152, 25);
        TbIdNumber.TabIndex = 2;
        TbIdNumber.KeyPress += TbIdNumber_KeyPress;
        // 
        // LblIdNumber
        // 
        LblIdNumber.AutoSize = true;
        LblIdNumber.Location = new System.Drawing.Point(443, 33);
        LblIdNumber.Name = "LblIdNumber";
        LblIdNumber.Size = new System.Drawing.Size(148, 17);
        LblIdNumber.TabIndex = 0;
        LblIdNumber.Text = "*Nro. de identificación";
        // 
        // TbFullName
        // 
        TbFullName.Location = new System.Drawing.Point(185, 83);
        TbFullName.Name = "TbFullName";
        TbFullName.Size = new System.Drawing.Size(152, 25);
        TbFullName.TabIndex = 2;
        TbFullName.KeyPress += TbFullName_KeyPress;
        // 
        // LblFullName
        // 
        LblFullName.AutoSize = true;
        LblFullName.Location = new System.Drawing.Point(21, 86);
        LblFullName.Name = "LblFullName";
        LblFullName.Size = new System.Drawing.Size(126, 17);
        LblFullName.TabIndex = 0;
        LblFullName.Text = "*Nombre completo";
        // 
        // SldStructureType
        // 
        SldStructureType.FormattingEnabled = true;
        SldStructureType.Items.AddRange(new object[] { "Pila", "Cola", "Lista" });
        SldStructureType.Location = new System.Drawing.Point(185, 239);
        SldStructureType.Name = "SldStructureType";
        SldStructureType.Size = new System.Drawing.Size(152, 25);
        SldStructureType.TabIndex = 1;
        SldStructureType.SelectedIndexChanged += SldStructureType_SelectedIndexChanged;
        // 
        // LblStructureType
        // 
        LblStructureType.AutoSize = true;
        LblStructureType.Location = new System.Drawing.Point(21, 242);
        LblStructureType.Name = "LblStructureType";
        LblStructureType.Size = new System.Drawing.Size(127, 17);
        LblStructureType.TabIndex = 0;
        LblStructureType.Text = "*Tipo de estructura";
        // 
        // SldStratum
        // 
        SldStratum.FormattingEnabled = true;
        SldStratum.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
        SldStratum.Location = new System.Drawing.Point(185, 135);
        SldStratum.Name = "SldStratum";
        SldStratum.Size = new System.Drawing.Size(152, 25);
        SldStratum.TabIndex = 1;
        SldStratum.SelectedIndexChanged += SldStratum_SelectedIndexChanged;
        // 
        // LblStratum
        // 
        LblStratum.AutoSize = true;
        LblStratum.Location = new System.Drawing.Point(21, 138);
        LblStratum.Name = "LblStratum";
        LblStratum.Size = new System.Drawing.Size(160, 17);
        LblStratum.TabIndex = 0;
        LblStratum.Text = "*Estrato socioeconómico";
        // 
        // SldIdType
        // 
        SldIdType.FormattingEnabled = true;
        SldIdType.Items.AddRange(new object[] { "CC", "CE", "NUIP", "PAS" });
        SldIdType.Location = new System.Drawing.Point(185, 33);
        SldIdType.Name = "SldIdType";
        SldIdType.Size = new System.Drawing.Size(152, 25);
        SldIdType.TabIndex = 1;
        // 
        // LblIdType
        // 
        LblIdType.AutoSize = true;
        LblIdType.Location = new System.Drawing.Point(21, 36);
        LblIdType.Name = "LblIdType";
        LblIdType.Size = new System.Drawing.Size(149, 17);
        LblIdType.TabIndex = 0;
        LblIdType.Text = "*Tipo de identificación";
        // 
        // tail
        // 
        tail.Controls.Add(DgvQueue);
        tail.Controls.Add(BtnQueueDelete);
        tail.Controls.Add(BtnQueueReport);
        tail.Location = new System.Drawing.Point(4, 24);
        tail.Name = "tail";
        tail.Padding = new System.Windows.Forms.Padding(3);
        tail.Size = new System.Drawing.Size(780, 173);
        tail.TabIndex = 2;
        tail.Text = "Cola";
        tail.UseVisualStyleBackColor = true;
        // 
        // DgvQueue
        // 
        DgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DgvQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
        DgvQueue.Location = new System.Drawing.Point(5, 4);
        DgvQueue.Name = "DgvQueue";
        DgvQueue.Size = new System.Drawing.Size(681, 164);
        DgvQueue.TabIndex = 6;
        DgvQueue.UseWaitCursor = true;
        DgvQueue.Visible = false;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.HeaderText = "ID";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.HeaderText = "Tipo de identificación";
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.HeaderText = "Nombre";
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.HeaderText = "Estrato";
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        // 
        // dataGridViewTextBoxColumn5
        // 
        dataGridViewTextBoxColumn5.HeaderText = "Salario";
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        // 
        // dataGridViewTextBoxColumn6
        // 
        dataGridViewTextBoxColumn6.HeaderText = "Valor del subsidio";
        dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        // 
        // BtnQueueDelete
        // 
        BtnQueueDelete.Enabled = false;
        BtnQueueDelete.Location = new System.Drawing.Point(692, 104);
        BtnQueueDelete.Name = "BtnQueueDelete";
        BtnQueueDelete.Size = new System.Drawing.Size(84, 31);
        BtnQueueDelete.TabIndex = 7;
        BtnQueueDelete.Text = "Eliminar";
        BtnQueueDelete.UseVisualStyleBackColor = true;
        BtnQueueDelete.Click += BtnQueueDelete_Click;
        // 
        // BtnQueueReport
        // 
        BtnQueueReport.Enabled = false;
        BtnQueueReport.Location = new System.Drawing.Point(692, 52);
        BtnQueueReport.Name = "BtnQueueReport";
        BtnQueueReport.Size = new System.Drawing.Size(84, 31);
        BtnQueueReport.TabIndex = 8;
        BtnQueueReport.Text = "Reporte";
        BtnQueueReport.UseVisualStyleBackColor = true;
        BtnQueueReport.Click += BtnQueueReport_Click;
        // 
        // stack
        // 
        stack.Controls.Add(DgvStack);
        stack.Controls.Add(BtnStackDelete);
        stack.Controls.Add(BtnStackReport);
        stack.Location = new System.Drawing.Point(4, 24);
        stack.Name = "stack";
        stack.Padding = new System.Windows.Forms.Padding(3);
        stack.Size = new System.Drawing.Size(780, 173);
        stack.TabIndex = 1;
        stack.Text = "Pila";
        // 
        // DgvStack
        // 
        DgvStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DgvStack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, idType, name, strate, salary, value });
        DgvStack.Location = new System.Drawing.Point(3, 5);
        DgvStack.Name = "DgvStack";
        DgvStack.Size = new System.Drawing.Size(681, 164);
        DgvStack.TabIndex = 0;
        DgvStack.UseWaitCursor = true;
        DgvStack.Visible = false;
        // 
        // id
        // 
        id.HeaderText = "ID";
        id.Name = "id";
        // 
        // idType
        // 
        idType.HeaderText = "Tipo de identificación";
        idType.Name = "idType";
        // 
        // name
        // 
        name.HeaderText = "Nombre";
        name.Name = "name";
        // 
        // strate
        // 
        strate.HeaderText = "Estrato";
        strate.Name = "strate";
        // 
        // salary
        // 
        salary.HeaderText = "Salario";
        salary.Name = "salary";
        // 
        // value
        // 
        value.HeaderText = "Valor del subsidio";
        value.Name = "value";
        // 
        // BtnStackDelete
        // 
        BtnStackDelete.Enabled = false;
        BtnStackDelete.Location = new System.Drawing.Point(690, 105);
        BtnStackDelete.Name = "BtnStackDelete";
        BtnStackDelete.Size = new System.Drawing.Size(84, 31);
        BtnStackDelete.TabIndex = 5;
        BtnStackDelete.Text = "Eliminar";
        BtnStackDelete.UseVisualStyleBackColor = true;
        BtnStackDelete.Click += BtnStackDelete_Click;
        // 
        // BtnStackReport
        // 
        BtnStackReport.Enabled = false;
        BtnStackReport.Location = new System.Drawing.Point(690, 53);
        BtnStackReport.Name = "BtnStackReport";
        BtnStackReport.Size = new System.Drawing.Size(84, 31);
        BtnStackReport.TabIndex = 5;
        BtnStackReport.Text = "Reporte";
        BtnStackReport.UseVisualStyleBackColor = true;
        BtnStackReport.Click += BtnStackReport_Click;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(stack);
        tabControl1.Controls.Add(tail);
        tabControl1.Controls.Add(list);
        tabControl1.Location = new System.Drawing.Point(29, 528);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(788, 201);
        tabControl1.TabIndex = 3;
        // 
        // list
        // 
        list.Controls.Add(DgvList);
        list.Controls.Add(BtnListDelete);
        list.Controls.Add(BtnListReport);
        list.Location = new System.Drawing.Point(4, 24);
        list.Name = "list";
        list.Size = new System.Drawing.Size(780, 173);
        list.TabIndex = 3;
        list.Text = "Lista";
        list.UseVisualStyleBackColor = true;
        // 
        // DgvList
        // 
        DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
        DgvList.Location = new System.Drawing.Point(5, 4);
        DgvList.MultiSelect = false;
        DgvList.Name = "DgvList";
        DgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        DgvList.Size = new System.Drawing.Size(681, 164);
        DgvList.TabIndex = 6;
        DgvList.UseWaitCursor = true;
        DgvList.Visible = false;
        // 
        // dataGridViewTextBoxColumn7
        // 
        dataGridViewTextBoxColumn7.HeaderText = "ID";
        dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        // 
        // dataGridViewTextBoxColumn8
        // 
        dataGridViewTextBoxColumn8.HeaderText = "Tipo de identificación";
        dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
        // 
        // dataGridViewTextBoxColumn9
        // 
        dataGridViewTextBoxColumn9.HeaderText = "Nombre";
        dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
        // 
        // dataGridViewTextBoxColumn10
        // 
        dataGridViewTextBoxColumn10.HeaderText = "Estrato";
        dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
        // 
        // dataGridViewTextBoxColumn11
        // 
        dataGridViewTextBoxColumn11.HeaderText = "Salario";
        dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
        // 
        // dataGridViewTextBoxColumn12
        // 
        dataGridViewTextBoxColumn12.HeaderText = "Valor del subsidio";
        dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
        // 
        // BtnListDelete
        // 
        BtnListDelete.Enabled = false;
        BtnListDelete.Location = new System.Drawing.Point(692, 104);
        BtnListDelete.Name = "BtnListDelete";
        BtnListDelete.Size = new System.Drawing.Size(84, 31);
        BtnListDelete.TabIndex = 7;
        BtnListDelete.Text = "Eliminar";
        BtnListDelete.UseVisualStyleBackColor = true;
        BtnListDelete.Click += BtnListDelete_Click;
        // 
        // BtnListReport
        // 
        BtnListReport.Enabled = false;
        BtnListReport.Location = new System.Drawing.Point(692, 52);
        BtnListReport.Name = "BtnListReport";
        BtnListReport.Size = new System.Drawing.Size(84, 31);
        BtnListReport.TabIndex = 8;
        BtnListReport.Text = "Reporte";
        BtnListReport.UseVisualStyleBackColor = true;
        BtnListReport.Click += BtnListReport_Click;
        // 
        // DataRegister
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.RosyBrown;
        ClientSize = new System.Drawing.Size(847, 740);
        Controls.Add(tabControl1);
        Controls.Add(GbAffiliateData);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Form2";
        GbAffiliateData.ResumeLayout(false);
        GbAffiliateData.PerformLayout();
        GbSisbenAffiliate.ResumeLayout(false);
        GbSisbenAffiliate.PerformLayout();
        tail.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DgvQueue).EndInit();
        stack.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DgvStack).EndInit();
        tabControl1.ResumeLayout(false);
        list.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DgvList).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

        #endregion

        public Label label1;
        public Label label2;
        public GroupBox GbAffiliateData;
        public ComboBox SldIdType;
        public Label LblIdType;
        public System.Windows.Forms.TextBox TbFullName;
        public Label LblFullName;
        public System.Windows.Forms.ComboBox SldStratum;
        public Label LblStratum;
        public System.Windows.Forms.TextBox TbDataReport;
        public Label LblDataReport;
        public TextBox TbSubsidyValue;
        public Label LblSubsidyValue;
        public System.Windows.Forms.TextBox TbSalary;
        public Label LblSalary;
        public System.Windows.Forms.TextBox TbIdNumber;
        public Label LblIdNumber;
        public System.Windows.Forms.ComboBox SldStructureType;
        public Label LblStructureType;
        public GroupBox GbSisbenAffiliate;
        public System.Windows.Forms.RadioButton CkbYes;
        public System.Windows.Forms.RadioButton CkbNo;
        public DateTimePicker DpDate;
        public Label LbDate;
        public Label label12;
        public System.Windows.Forms.Button BtnClose;
        public System.Windows.Forms.Button BtnClear;
        public System.Windows.Forms.Button BtnRegister;
        public TabPage tail;
        public TabPage stack;
        public TabControl tabControl1;
        public TabPage list;
        public DataGridView DgvStack;
        public System.Windows.Forms.Button BtnStackReport;
        public System.Windows.Forms.Button BtnStackDelete;
        public DataGridViewTextBoxColumn id;
        public DataGridViewTextBoxColumn idType;
        public DataGridViewTextBoxColumn name;
        public DataGridViewTextBoxColumn strate;
        public DataGridViewTextBoxColumn salary;
        public DataGridViewTextBoxColumn value;
        public DataGridView DgvQueue;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        public System.Windows.Forms.Button BtnQueueDelete;
        public System.Windows.Forms.Button BtnQueueReport;
        public DataGridView DgvList;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        public DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        public System.Windows.Forms.Button BtnListDelete;
        public System.Windows.Forms.Button BtnListReport;
}