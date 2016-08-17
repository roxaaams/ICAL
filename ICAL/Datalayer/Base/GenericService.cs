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

using System;
using System.Data;
using ICAL_Final.Database;

namespace ICAL_Final.Datalayer.Base
{
    public abstract class GenericService<TTableRow, TDataTable, TDataTableAdapter> : IDisposable
        where TDataTable : DataTable
        where TDataTableAdapter : new()
    {
        protected ICALDatabaseDataSet DataSet { get; set; }
        protected TDataTable Table { get; set; }
        protected TDataTableAdapter TableAdapter { get; set; }

        protected GenericService()
        {
           DataSet = new ICALDatabaseDataSet();
           TableAdapter = new TDataTableAdapter();

           Table = (TDataTable)DataSet.Tables[typeof(TDataTable).Name.Replace("DataTable", string.Empty)];
        }

        public abstract TTableRow Get(int id);

        public abstract TTableRow[] GetAll();

        public abstract TTableRow CreateNewEntity();

        public abstract TTableRow Insert(TTableRow entity);

        public abstract TTableRow Update(TTableRow entity);

        public abstract bool Delete(int id);

        public abstract bool DeleteAll();

        public abstract bool SaveChanges();

        public void Dispose()
        {
           DataSet.Dispose();
        }
    }
}

