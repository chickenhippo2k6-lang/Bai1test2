
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GymMemberManager
{
    public class MemberModel : INotifyPropertyChanged
    {
        private string _memberId = "";
        private string _fullName = "";
        private string _phone = "";
        private string _package = "";
        private DateTime _startDate = DateTime.Today;
        private int _fee;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Notify([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(name));
        }

        public string MemberId
        {
            get => _memberId;
            set { _memberId = value; Notify(); }
        }

        public string FullName
        {
            get => _fullName;
            set { _fullName = value; Notify(); }
        }

        public string Phone
        {
            get => _phone;
            set { _phone = value; Notify(); }
        }

        public string Package
        {
            get => _package;
            set { _package = value; Notify(); }
        }

        public DateTime StartDate
        {
            get => _startDate;
            set { _startDate = value; Notify(); }
        }

        public int Fee
        {
            get => _fee;
            set { _fee = value; Notify(); }
        }
    }
}
