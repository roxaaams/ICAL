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
    public class TestQuestionService : GenericService<ICALDatabaseDataSet.TestQuestionsRow,
       ICALDatabaseDataSet.TestQuestionsDataTable, TestQuestionsTableAdapter>
    {
        public TestQuestionService()
        {
            TableAdapter.Fill(Table);
        }

        public override ICALDatabaseDataSet.TestQuestionsRow Get(int id)
        {
            return Table.FindById(id);
        }

        public ICALDatabaseDataSet.TestQuestionsRow[] GetAfterChapter(int idChapter)
        {
            return Table.Where(e => e.IdChapter == idChapter).ToArray();
        }

        public ICALDatabaseDataSet.TestQuestionsRow[] GetAfterChapterAndLevel(int idChapter, string level)
        {
            return Table.Where(e => e.IdChapter == idChapter && e.Level == level).ToArray();
        }

        public override ICALDatabaseDataSet.TestQuestionsRow[] GetAll()
        {
            return Table.ToArray();
        }

        public override ICALDatabaseDataSet.TestQuestionsRow CreateNewEntity()
        {
            return Table.NewTestQuestionsRow();
        }

        public override ICALDatabaseDataSet.TestQuestionsRow Insert(ICALDatabaseDataSet.TestQuestionsRow entity)
        {
            Table.AddTestQuestionsRow(entity);

            SaveChanges();

            var maxId = GetMaxId();

            return Table.FindById(maxId);
        }

        public override ICALDatabaseDataSet.TestQuestionsRow Update(ICALDatabaseDataSet.TestQuestionsRow entity)
        {
            var dbEntity = Table.FindById(entity.Id);

            dbEntity.IdChapter = entity.IdChapter;
            dbEntity.Level = entity.Level;
            dbEntity.Question = entity.Question;
            dbEntity.FirstAnswer = entity.FirstAnswer;
            dbEntity.SecondAnswer = entity.SecondAnswer;
            dbEntity.ThirdAnswer = entity.ThirdAnswer;
            dbEntity.CorrectAnswer = entity.CorrectAnswer;

            SaveChanges();

            return Table.FindById(entity.Id);
        }

        public override bool Delete(int id)
        {
            var entity = Get(id);

            Table.RemoveTestQuestionsRow(entity);

            return SaveChanges();
        }

        public bool DeleteAfterChapter(int idChapter)
        {
            var entities = GetAfterChapter(idChapter);

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

        private int GetMaxId()
        {
            return Table.Max(e => e.Id);
        }
    }

}
