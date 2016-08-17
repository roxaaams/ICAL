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

using System.Linq;
using ICAL_Final.Database;
using ICAL_Final.Database.ICALDatabaseDataSetTableAdapters;
using ICAL_Final.Datalayer.Base;

namespace ICAL_Final.Datalayer
{
    public class MoodService : GenericService<ICALDatabaseDataSet.MoodsRow,
       ICALDatabaseDataSet.MoodsDataTable, MoodsTableAdapter>
    {
        public MoodService()
        {
            TableAdapter.Fill(Table);
        } 

        public override ICALDatabaseDataSet.MoodsRow Get(int id)
        {
            return Table.FindById(id);
        }

        public override ICALDatabaseDataSet.MoodsRow[] GetAll()
        {
            return Table.ToArray();
        }

        public override ICALDatabaseDataSet.MoodsRow CreateNewEntity()
        {
            return Table.NewMoodsRow();
        }

        public override ICALDatabaseDataSet.MoodsRow Insert(ICALDatabaseDataSet.MoodsRow entity)
        {
            Table.AddMoodsRow(entity);

            SaveChanges();

            var maxId = GetMaxId();

            return Table.FindById(maxId);
        }

        public override ICALDatabaseDataSet.MoodsRow Update(ICALDatabaseDataSet.MoodsRow entity)
        {
            var dbEntity = Table.FindById(entity.Id);

            dbEntity.Name = entity.Name;
            dbEntity.Picture = entity.Picture;

            SaveChanges();

            return Table.FindById(entity.Id);
        }

        public override bool Delete(int id)
        {
            var entity = Get(id);

            Table.RemoveMoodsRow(entity);

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

        private int GetMaxId()
        {
            return Table.Max(e => e.Id);
        }
    }
}
