
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GymMemberManager
{
    public partial class Form1 : Form
    {
        private readonly BindingList<MemberModel> members = new();
        private readonly BindingSource bindingSource = new();

        private MemberModel? selectedMember;
        private int nextId = 1;
        private bool loading = false;

        public Form1()
        {
            InitializeComponent();

            SetupGrid();

            bindingSource.DataSource = members;
            dgvMembers.DataSource = bindingSource;

            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnReset.Click += btnReset_Click;

            dgvMembers.SelectionChanged +=
                dgvMembers_SelectionChanged;

            ResetForm();
        }

        private void SetupGrid()
        {
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.Columns.Clear();

            AddColumn("Mã HV", nameof(MemberModel.MemberId));
            AddColumn("Tên hội viên", nameof(MemberModel.FullName));
            AddColumn("SĐT", nameof(MemberModel.Phone));
            AddColumn("Gói tập", nameof(MemberModel.Package));

            DataGridViewTextBoxColumn dateCol = new()
            {
                Name = "colStartDate",
                HeaderText = "Ngày ĐK",
                DataPropertyName = nameof(MemberModel.StartDate),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy"
                }
            };

            dgvMembers.Columns.Add(dateCol);

            DataGridViewTextBoxColumn feeCol = new()
            {
                Name = "colFee",
                HeaderText = "Phí dịch vụ",
                DataPropertyName = nameof(MemberModel.Fee),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment =
                        DataGridViewContentAlignment.MiddleRight
                }
            };

            dgvMembers.Columns.Add(feeCol);
        }

        private void AddColumn(string header, string property)
        {
            DataGridViewTextBoxColumn col = new()
            {
                Name = "col" + property,
                HeaderText = header,
                DataPropertyName = property,
                ReadOnly = true
            };

            dgvMembers.Columns.Add(col);
        }

        private string GenerateId()
        {
            return "HV" + nextId.ToString("D3");
        }

        private void ResetForm()
        {
            loading = true;

            selectedMember = null;

            bindingSource.Position = -1;
            dgvMembers.ClearSelection();
            dgvMembers.CurrentCell = null;

            txtMemberId.Text = GenerateId();
            txtFullName.Clear();
            txtPhone.Clear();
            txtFee.Clear();

            cboPackage.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Today;

            errorProvider1.Clear();

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            loading = false;

            txtFullName.Focus();
        }

        private bool ValidateInput()
        {
            errorProvider1.Clear();

            bool valid = true;

            string name = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string feeText = txtFee.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider1.SetError(
                    txtFullName,
                    "Tên hội viên không được để trống.");

                valid = false;
            }
            else if (!Regex.IsMatch(
                name,
                @"^[\p{L}\p{M}]+(?:\s+[\p{L}\p{M}]+)*$"))
            {
                errorProvider1.SetError(
                    txtFullName,
                    "Tên không được chứa số hoặc ký tự đặc biệt.");

                valid = false;
            }

            if (!Regex.IsMatch(phone, @"^[0-9]{10}$"))
            {
                errorProvider1.SetError(
                    txtPhone,
                    "Số điện thoại phải có đúng 10 chữ số.");

                valid = false;
            }

            if (!int.TryParse(feeText, out int fee) || fee <= 0)
            {
                errorProvider1.SetError(
                    txtFee,
                    "Phí dịch vụ phải là số nguyên dương.");

                valid = false;
            }

            if (cboPackage.SelectedIndex < 0)
            {
                errorProvider1.SetError(
                    cboPackage,
                    "Vui lòng chọn gói tập.");

                valid = false;
            }

            if (dtpStartDate.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(
                    dtpStartDate,
                    "Ngày đăng ký không được lớn hơn ngày hiện tại.");

                valid = false;
            }

            return valid;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            MemberModel member = new()
            {
                MemberId = GenerateId(),
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Package = cboPackage.Text,
                StartDate = dtpStartDate.Value.Date,
                Fee = int.Parse(txtFee.Text.Trim())
            };

            loading = true;

            members.Add(member);
            nextId++;

            loading = false;

            MessageBox.Show(
                "Thêm hội viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ResetForm();
        }

        private void dgvMembers_SelectionChanged(
            object? sender, EventArgs e)
        {
            if (loading)
                return;

            if (dgvMembers.SelectedRows.Count == 0)
                return;

            MemberModel? member =
                dgvMembers.SelectedRows[0].DataBoundItem
                as MemberModel;

            if (member == null)
                return;

            selectedMember = member;

            loading = true;

            txtMemberId.Text = member.MemberId;
            txtFullName.Text = member.FullName;
            txtPhone.Text = member.Phone;

            cboPackage.SelectedItem = member.Package;
            dtpStartDate.Value = member.StartDate;
            txtFee.Text = member.Fee.ToString();

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            errorProvider1.Clear();

            loading = false;
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (selectedMember == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn hội viên cần sửa.");
                return;
            }

            if (!ValidateInput())
                return;

            loading = true;

            selectedMember.FullName = txtFullName.Text.Trim();
            selectedMember.Phone = txtPhone.Text.Trim();
            selectedMember.Package = cboPackage.Text;
            selectedMember.StartDate = dtpStartDate.Value.Date;
            selectedMember.Fee = int.Parse(txtFee.Text.Trim());

            loading = false;

            MessageBox.Show(
                "Cập nhật thông tin thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (selectedMember == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn hội viên cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa hội viên "
                + selectedMember.FullName + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            loading = true;

            members.Remove(selectedMember);

            loading = false;

            MessageBox.Show(
                "Xóa hội viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ResetForm();
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
