/* Copyright 2015-2016 Roxana Teodora Mafteiu-Scai, Diana Fabiola Popa
#
# This file is part of ICAL - Intelligent Computer Assisted Learning.
#
# ICAL - Intelligent Computer Assisted Learning is free software: you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation, either version 3 of the License, or
# (at your option) any later version.
#
# ICAL - Intelligent Computer Assisted Learning is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with ICAL - Intelligent Computer Assisted Learning.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Data;
using System.Linq;
using ICAL_Final.Database;
using ICAL_Final.Database.ICALDatabaseDataSetTableAdapters;
using ICAL_Final.Datalayer.Base;

namespace ICAL_Final.Datalayer
{
    public class AttendedChapterService : GenericService<ICALDatabaseDataSet.AttendedChaptersRow,
       ICALDatabaseDataSet.AttendedChaptersDataTable, AttendedChaptersTableAdapter>
    {

        public AttendedChapterService()
        {
            TableAdapter.Fill(Table);
        }

        public override ICALDatabaseDataSet.AttendedChaptersRow Get(int id)
        {
            return Table.FindById(id);
        }

        public ICALDatabaseDataSet.AttendedChaptersRow[] GetAfterIdStudent(int idStudent)
        {
            return Table.Where(d => d.IdStudent == idStudent).ToArray();
        }

        public ICALDatabaseDataSet.AttendedChaptersRow[] GetAfterIdChapterAndIdStudent(int idChapter, int idStudent)
        {
            return Table.Where(d => d.IdChapter == idChapter && d.IdStudent == idStudent).ToArray();
        }

        public override ICALDatabaseDataSet.AttendedChaptersRow[] GetAll()
        {
            return Table.ToArray();
        }

        public override ICALDatabaseDataSet.AttendedChaptersRow CreateNewEntity()
        {
            return Table.NewAttendedChaptersRow();
        }

        public override ICALDatabaseDataSet.AttendedChaptersRow Insert(ICALDatabaseDataSet.AttendedChaptersRow entity)
        {
            Table.AddAttendedChaptersRow(entity);

            SaveChanges();

            var maxId = GetMaxId();

            return Table.FindById(maxId);
        }

        public override ICALDatabaseDataSet.AttendedChaptersRow Update(ICALDatabaseDataSet.AttendedChaptersRow entity)
        {
            var dbEntity = Table.FindById(entity.Id);

            dbEntity.Score = entity.Score;

            SaveChanges();

            return Table.FindById(entity.Id);
        }

        public override bool Delete(int id)
        {
            var entity = Get(id);

            Table.RemoveAttendedChaptersRow(entity);

            return SaveChanges();
        }

        public bool DeleteAllAfterIdStudent(int idStudent)
        {
            var entities = GetAfterIdStudent(idStudent);
            foreach (var entity in entities)
            {
                entity.Delete();
            } 

            return SaveChanges();
        }

        public override bool DeleteAll()
        {
            var entities = GetAll();

            foreach (var entity in entities)
            {
                entity.Delete();
            }

            return SaveChanges();
        }

        public override bool SaveChanges()
        {
            var numberOfUpdates = TableAdapter.Update(Table);

            return numberOfUpdates > 0;
        }

        public int ChaptersAttentedByIdStudent(int idStudent)
        {
            return Table.Count(d => d.IdStudent == idStudent);
        }

        private int GetMaxId()
        {
            return Table.Max(e => e.Id);
        }

    }
}
