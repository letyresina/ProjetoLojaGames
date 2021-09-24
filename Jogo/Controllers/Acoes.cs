using Jogo.Repositorio;
using MySql.Data.MySqlClient;
using Jogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jogo.Controllers
{
    public class Acoes
    {
        ParteConexao con = new ParteConexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarCliente(Cliente client)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbCliente values(@CliNome, @CliCPF, @CliDtNasc, @EmailCli, @CelCli, " +
                "@EnderecoCli)", con.ConectarBD());
            string data_sistema = Convert.ToDateTime(client.CliDtNasc).ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@CliNome", MySqlDbType.VarChar).Value = client.CliNome;
            cmd.Parameters.Add("@CliCPF", MySqlDbType.VarChar).Value = client.CliCPF;
            cmd.Parameters.Add("@CliDtNasc", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@EmailCli", MySqlDbType.VarChar).Value = client.EmailCli;
            cmd.Parameters.Add("@CelCli", MySqlDbType.VarChar).Value = client.CelCli;
            cmd.Parameters.Add("@EnderecoCli", MySqlDbType.VarChar).Value = client.EnderecoCli;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public void CadastrarFuncionario(Funcionario func)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbFuncionario values(@FuncCod, @FuncNome, @CPFFunc, @RGFunc, @FuncDtNasc, " +
                "@EmailFunc, @CelFunc, @Cargo ,@EnderecoFunc)", con.ConectarBD());
            string data_sistema = Convert.ToDateTime(func.FuncDtNasc).ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@FuncCod", MySqlDbType.Int24).Value = func.FuncCod;
            cmd.Parameters.Add("@FuncNome", MySqlDbType.VarChar).Value = func.FuncNome;
            cmd.Parameters.Add("@CPFFunc", MySqlDbType.VarChar).Value = func.CPFFunc;
            cmd.Parameters.Add("@RGFunc", MySqlDbType.VarChar).Value = func.RGFunc;
            cmd.Parameters.Add("@FuncDtNasc", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@EmailFunc", MySqlDbType.VarChar).Value = func.EmailFunc;
            cmd.Parameters.Add("@CelFunc", MySqlDbType.VarChar).Value = func.CelFunc;
            cmd.Parameters.Add("@Cargo", MySqlDbType.VarChar).Value = func.Cargo;
            cmd.Parameters.Add("@EnderecoFunc", MySqlDbType.VarChar).Value = func.EnderecoFunc;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public void CadastrarJogo(JogoClasse jogo)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbJogo values(@JogoCod, @JogoNome, @Versao, @JogoDesenvolvedor, " +
                "@GeneroJogo, @FaixaEtaria, @Plataforma, @AnoLanc, @Sinopse)", con.ConectarBD());
            cmd.Parameters.Add("@JogoCod", MySqlDbType.Int24).Value = jogo.JogoCod;
            cmd.Parameters.Add("@JogoNome", MySqlDbType.VarChar).Value = jogo.JogoNome;
            cmd.Parameters.Add("@Versao", MySqlDbType.VarChar).Value = jogo.Versao;
            cmd.Parameters.Add("@JogoDesenvolvedor", MySqlDbType.VarChar).Value = jogo.JogoDesenvolvedor;
            cmd.Parameters.Add("@GeneroJogo", MySqlDbType.VarChar).Value = jogo.GeneroJogo;
            cmd.Parameters.Add("@FaixaEtaria", MySqlDbType.VarChar).Value = jogo.FaixaEtaria;
            cmd.Parameters.Add("@Plataforma", MySqlDbType.VarChar).Value = jogo.Plataforma;
            cmd.Parameters.Add("@AnoLanc", MySqlDbType.VarChar).Value = jogo.AnoLanc;
            cmd.Parameters.Add("@Sinopse", MySqlDbType.VarChar).Value = jogo.Sinopse;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }
    }
}