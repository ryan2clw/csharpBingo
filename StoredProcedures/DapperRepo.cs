﻿using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


public interface IEmployeeRepository
{

    Task<Employee> GetByID(int id);
    Task<List<Employee>> GetByDateOfBirth(DateTime dateOfBirth);
}
public class EmployeeRepository : IEmployeeRepository
{
    private readonly IConfiguration _config;

    public EmployeeRepository(IConfiguration config)
    {
        _config = config;
    }
    public IDbConnection Connection
    {
        get
        {
            return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        }
    }
    public async Task<Employee> GetByID(int id)
    {
        using (IDbConnection conn = Connection)
        {
            string sQuery = "SELECT ID, FirstName, LastName, DateOfBirth FROM Employee WHERE ID = @ID";
            conn.Open();
            var result = await conn.QueryAsync<Employee>(sQuery, new { ID = id });
            return result.FirstOrDefault();
        }
    }

    public async Task<List<Employee>> GetByDateOfBirth(DateTime dateOfBirth)
    {
        using (IDbConnection conn = Connection)
        {
            string sQuery = "SELECT ID, FirstName, LastName, DateOfBirth FROM Employee WHERE DateOfBirth = @DateOfBirth";
            conn.Open();
            var result = await conn.QueryAsync<Employee>(sQuery, new { DateOfBirth = dateOfBirth });
            return result.ToList();
        }

    }
}
