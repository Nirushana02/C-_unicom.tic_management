using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTIC_Management_System.Controller.cs;
using UnicomTIC_Management_System.Models;

namespace UnicomTIC_Management_System.Views
{
    public partial class TimetableForm : Form
    {
        private Timetable_Controller timetable_Controller = new Timetable_Controller();
        private Subject_Controller subject_Controller = new Subject_Controller();
        private Room_Controller room_Controller = new Room_Controller();
        private int Clicked_Timetable_Id;
        public TimetableForm()
        {
            InitializeComponent();
            this.Load += TimetableForm_Load;
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            var timetable = new Timetable
            {
                SubjectId = Convert.ToInt32(combo_sbu.SelectedValue),
                RoomId = Convert.ToInt32(combo_room.SelectedValue),
                TimeSlot = txt_time.Text.Trim()
            };

            await timetable_Controller.AddAsync(timetable);
            txt_time.Clear();
            await LoadTimetables();
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (Clicked_Timetable_Id != -1)
            {
                await timetable_Controller.UpdateAsync(new Timetable
                {
                    Id = Clicked_Timetable_Id,
                    SubjectId = Convert.ToInt32(combo_sbu.SelectedValue),
                    RoomId = Convert.ToInt32(combo_room.SelectedValue),
                    TimeSlot = txt_time.Text.Trim()
                });

                txt_time.Clear();
                Clicked_Timetable_Id = -1;
                await LoadTimetables();
            }
        }

        private void dgv_timetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_timetable.Rows[e.RowIndex];

                Clicked_Timetable_Id = Convert.ToInt32(row.Cells["Id"].Value);
                combo_sbu.Text = row.Cells["SubjectName"].Value.ToString();
                txt_time.Text = row.Cells["TimeSlot"].Value.ToString();
                combo_room.Text = row.Cells["RoomName"].Value.ToString();
            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (Clicked_Timetable_Id != -1)
            {
                await timetable_Controller.DeleteAsync(Clicked_Timetable_Id);
                txt_time.Clear();
                Clicked_Timetable_Id = -1;
                await LoadTimetables();
            }
        }

        private async void TimetableForm_Load(object sender, EventArgs e)
        {
            await LoadTimetables();
            await LoadSubjects();
            await LoadRooms();
        }

        private async Task LoadTimetables()
        {
            dgv_timetable.DataSource = await timetable_Controller.show_TimetableAsync();
        }

        private async Task LoadSubjects()
        {
            var subjects = await subject_Controller.GetAllSubjectsAsync();
            combo_sbu.DataSource = subjects;
            combo_sbu.DisplayMember = "SubjectName";
            combo_sbu.ValueMember = "SubjectId";
        }

        private async Task LoadRooms()
        {
            var rooms = await room_Controller.GetAllAsync();
            combo_room.DataSource = rooms;
            combo_room.DisplayMember = "RoomName";
            combo_room.ValueMember = "RoomId";
        }
    }
}
