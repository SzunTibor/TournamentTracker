﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
  public class SqlConnector : IDataConnection
  {
    /// <summary>
    /// Saves a new Person to the database.
    /// </summary>
    /// <param name="model">The PersonModel to save.</param>
    /// <returns>The PersonModel with it's Id set.</returns>
    public PersonModel CreatePerson(PersonModel model)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
      {
        var p = new DynamicParameters();
        p.Add("@FirstName", model.FirstName);
        p.Add("@LastName", model.LastName);
        p.Add("@EmailAddress", model.EmailAddress);
        p.Add("@CellPhoneNumber", model.CellPhoneNumber);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

        model.Id = p.Get<int>("@id");

        return model;
      }
    }

    /// <summary>
    /// Saves a new Prize to the database.
    /// </summary>
    /// <param name="model">The PrizeModel to save.</param>
    /// <returns>The PrizeModel with it's Id set.</returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
      {
        var p = new DynamicParameters();
        p.Add("@PlaceNumber", model.PlaceNumber);
        p.Add("@PlaceName", model.PlaceName);
        p.Add("@PrizeAmount", model.PrizeAmount);
        p.Add("@PrizePercentage", model.PrizePercentage);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

        model.Id = p.Get<int>("@id");

        return model;
      }
    }
  }
}
