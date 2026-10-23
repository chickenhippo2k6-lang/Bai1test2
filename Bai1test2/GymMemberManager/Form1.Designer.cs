
namespace GymMemberManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

        private TableLayoutPanel tableMain = null!;
        private TableLayoutPanel tableInput = null!;
        private FlowLayoutPanel panelButtons = null!;

        private GroupBox grpInfo = null!;
        private GroupBox grpList = null!;

        private Label lblMemberId = null!;
        private Label lblFullName = null!;
        private Label lblPhone = null!;
        private Label lblPackage = null!;
        private Label lblStartDate = null!;
        private Label lblFee = null!;

        private TextBox txtMemberId = null!;
        private TextBox txtFullName = null!;
        private TextBox txtPhone = null!;
        private TextBox txtFee = null!;

        private ComboBox cboPackage = null!;
        private DateTimePicker dtpStartDate = null!;

        private Button btnAdd = null!;
        private Button btnEdit = null!;
        private Button btnDelete = null!;
        private Button btnReset = null!;

        private DataGridView dgvMembers = null!;
        private ErrorProvider errorProvider1 = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableMain = new TableLayoutPanel();
            grpInfo = new GroupBox();
            tableInput = new TableLayoutPanel();
            lblMemberId = new Label();
            txtMemberId = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblPackage = new Label();
            cboPackage = new ComboBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblFee = new Label();
            txtFee = new TextBox();
            panelButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            grpList = new GroupBox();
            dgvMembers = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            tableMain.SuspendLayout();
            grpInfo.SuspendLayout();
            tableInput.SuspendLayout();
            panelButtons.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableMain
            // 
            tableMain.ColumnCount = 2;
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            tableMain.Controls.Add(grpInfo, 0, 0);
            tableMain.Controls.Add(grpList, 1, 0);
            tableMain.Dock = DockStyle.Fill;
            tableMain.Location = new Point(0, 0);
            tableMain.Name = "tableMain";
            tableMain.Padding = new Padding(12);
            tableMain.RowCount = 1;
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableMain.Size = new Size(1200, 547);
            tableMain.TabIndex = 0;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(tableInput);
            grpInfo.Dock = DockStyle.Fill;
            grpInfo.Location = new Point(15, 15);
            grpInfo.Name = "grpInfo";
            grpInfo.Padding = new Padding(12);
            grpInfo.Size = new Size(440, 517);
            grpInfo.TabIndex = 0;
            grpInfo.TabStop = false;
            grpInfo.Text = "THÔNG TIN HỘI VIÊN";
            // 
            // tableInput
            // 
            tableInput.ColumnCount = 2;
            tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            tableInput.Controls.Add(lblMemberId, 0, 0);
            tableInput.Controls.Add(txtMemberId, 1, 0);
            tableInput.Controls.Add(lblFullName, 0, 1);
            tableInput.Controls.Add(txtFullName, 1, 1);
            tableInput.Controls.Add(lblPhone, 0, 2);
            tableInput.Controls.Add(txtPhone, 1, 2);
            tableInput.Controls.Add(lblPackage, 0, 3);
            tableInput.Controls.Add(cboPackage, 1, 3);
            tableInput.Controls.Add(lblStartDate, 0, 4);
            tableInput.Controls.Add(dtpStartDate, 1, 4);
            tableInput.Controls.Add(lblFee, 0, 5);
            tableInput.Controls.Add(txtFee, 1, 5);
            tableInput.Controls.Add(panelButtons, 0, 6);
            tableInput.Dock = DockStyle.Fill;
            tableInput.Location = new Point(12, 35);
            tableInput.Name = "tableInput";
            tableInput.RowCount = 7;
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableInput.Size = new Size(416, 470);
            tableInput.TabIndex = 0;
            // 
            // lblMemberId
            // 
            lblMemberId.Dock = DockStyle.Fill;
            lblMemberId.Location = new Point(3, 0);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(143, 55);
            lblMemberId.TabIndex = 0;
            lblMemberId.Text = "Mã hội viên";
            lblMemberId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMemberId
            // 
            txtMemberId.BackColor = Color.WhiteSmoke;
            txtMemberId.Dock = DockStyle.Fill;
            txtMemberId.Location = new Point(152, 9);
            txtMemberId.Margin = new Padding(3, 9, 18, 9);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(246, 30);
            txtMemberId.TabIndex = 0;
            // 
            // lblFullName
            // 
            lblFullName.Dock = DockStyle.Fill;
            lblFullName.Location = new Point(3, 55);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(143, 55);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ và tên";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFullName
            // 
            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Location = new Point(152, 64);
            txtFullName.Margin = new Padding(3, 9, 18, 9);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(246, 30);
            txtFullName.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Location = new Point(3, 110);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(143, 55);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Số điện thoại";
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(152, 119);
            txtPhone.Margin = new Padding(3, 9, 18, 9);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(246, 30);
            txtPhone.TabIndex = 2;
            // 
            // lblPackage
            // 
            lblPackage.Dock = DockStyle.Fill;
            lblPackage.Location = new Point(3, 165);
            lblPackage.Name = "lblPackage";
            lblPackage.Size = new Size(143, 55);
            lblPackage.TabIndex = 3;
            lblPackage.Text = "Gói tập";
            lblPackage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboPackage
            // 
            cboPackage.Dock = DockStyle.Fill;
            cboPackage.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPackage.FormattingEnabled = true;
            cboPackage.Items.AddRange(new object[] { "Theo tháng", "6 tháng", "1 năm" });
            cboPackage.Location = new Point(152, 174);
            cboPackage.Margin = new Padding(3, 9, 18, 9);
            cboPackage.Name = "cboPackage";
            cboPackage.Size = new Size(246, 31);
            cboPackage.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.Dock = DockStyle.Fill;
            lblStartDate.Location = new Point(3, 220);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(143, 55);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Ngày đăng ký";
            lblStartDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Dock = DockStyle.Fill;
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(152, 229);
            dtpStartDate.Margin = new Padding(3, 9, 18, 9);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(246, 30);
            dtpStartDate.TabIndex = 4;
            // 
            // lblFee
            // 
            lblFee.Dock = DockStyle.Fill;
            lblFee.Location = new Point(3, 275);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(143, 55);
            lblFee.TabIndex = 5;
            lblFee.Text = "Phí dịch vụ";
            lblFee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFee
            // 
            txtFee.Dock = DockStyle.Fill;
            txtFee.Location = new Point(152, 284);
            txtFee.Margin = new Padding(3, 9, 18, 9);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(246, 30);
            txtFee.TabIndex = 5;
            // 
            // panelButtons
            // 
            tableInput.SetColumnSpan(panelButtons, 2);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnEdit);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnReset);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 333);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(0, 15, 0, 0);
            panelButtons.Size = new Size(410, 134);
            panelButtons.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(4, 19);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(157, 19);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(145, 42);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa thông tin";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(4, 69);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa hội viên";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(157, 69);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(145, 42);
            btnReset.TabIndex = 3;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // grpList
            // 
            grpList.Controls.Add(dgvMembers);
            grpList.Dock = DockStyle.Fill;
            grpList.Location = new Point(461, 15);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(12);
            grpList.Size = new Size(724, 517);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "DANH SÁCH HỘI VIÊN";
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AllowUserToResizeRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.ColumnHeadersHeight = 29;
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.Location = new Point(12, 35);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(700, 470);
            dgvMembers.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 547);
            Controls.Add(tableMain);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1000, 520);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ PHÒNG GYM";
            tableMain.ResumeLayout(false);
            grpInfo.ResumeLayout(false);
            tableInput.ResumeLayout(false);
            tableInput.PerformLayout();
            panelButtons.ResumeLayout(false);
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }
    }
}
