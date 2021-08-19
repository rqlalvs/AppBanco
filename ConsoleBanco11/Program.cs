using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Console;

namespace ConsoleBanco11
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int opc;

            var usuario = new Usuario();

            var usuarioDAO = new UsuarioDAO();

            var leitor = usuarioDAO.Listar();

            foreach (var usuarios in leitor)
            {
                WriteLine("Id: {0}, Nome: {1}, Cargo: {2}, Data: {3}", usuarios.IdUsu, usuarios.NomeUsu, usuarios.Cargo, usuarios.Data);
            }

            Console.ReadLine();

            Console.WriteLine("1 - EXCLUIR");
            Console.WriteLine("2 - ADICIONAR/ATUALIZAR");
            Console.WriteLine("3 - SAIR");

            opc = Convert.ToInt16( ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine(" EXCLUIR");

                    WriteLine("*===========================================*");

                    WriteLine("| Digite o id                               |");

                    WriteLine("*===========================================*");

                    usuario.IdUsu = Convert.ToInt16(ReadLine());

                    new UsuarioDAO().Excluir(usuario);

                    WriteLine("Excluido!");


                    break;
                case 2:
                    Console.WriteLine("2 - ADICIONAR/ATUALIZAR");

                    WriteLine("*======================================================================================*");

                    WriteLine("| Digite o id 0 pra adicionar e um existente pra atualizar                             |");
                    usuario.IdUsu = Convert.ToInt16(ReadLine());

                    WriteLine("| Digite o nome do usuário                                                             |");
                    usuario.NomeUsu = ReadLine();

                    WriteLine("| Digite o cargo do usuário                                                            |");
                    usuario.Cargo = ReadLine();

                    WriteLine("| Digite a data de nascimento do usuário                                               |");
                    usuario.Data = Convert.ToDateTime(ReadLine());

                    WriteLine("*======================================================================================*");



                    new UsuarioDAO().Salvar(usuario);

                    WriteLine("Salvo!");

                    break;

                case 3:


                    Console.WriteLine("Falou");
                    ReadKey();


                    new UsuarioDAO().Salvar(usuario);

                    WriteLine("Salvo!");

                    break;
      
                  
                   
     
                    
                default:

                    WriteLine("Digite uma opção válida");

                    break;
            }




            var leitor1 = usuarioDAO.Listar();

            foreach (var usuarios in leitor1)
            {
                WriteLine("Id: {0}, Nome: {1}, Cargo: {2}, Data: {3}", usuarios.IdUsu, usuarios.NomeUsu, usuarios.Cargo, usuarios.Data);
            }


            Console.ReadLine();
        }
    }
}

/*
 
       
     */
// usuario.IdUsu = 8;


//new UsuarioDAO().Excluir(usuario);

//WriteLine("excluido carai");


/* int linhasaf = new UsuarioDAO().Atualizar(usuario);

 if (linhasaf == 0)
 {
     new UsuarioDAO().Insert(usuario);
 }*/

// var leitor = new Banco().RetornaComando("SELECT * FROM TBUsuario");

// SqlConnection conexao = new SqlConnection(@"Data Source = DESKTOP-B3CTRV3; Initial Catalog = dbEXEMPLO; User ID = sa; Password = 1234567");

//SqlConnection conexao = new SqlConnection(Properties.Settings.Default.conexao);
//conexao.Open();

//SqlCommand strIns = new SqlCommand(stringIns, conexao);
//strIns.ExecuteNonQuery();

//SqlCommand strdel = new SqlCommand("Delete from tbUsuario where idUsu = 2", conexao);
//strdel.ExecuteNonQuery();

//SqlCommand strins = new SqlCommand("Insert into tbUsuario(NomeUsu, Cargo, Data)" + "values('Emma', 'Cerimonialista', '04/17/2000')", conexao);
//strins.ExecuteNonQuery();

//SqlCommand comando = new SqlCommand("Select * from tbUsuario", conexao);
//SqlDataReader leitor = comando.ExecuteReader();

//string stringIns = string.Format("Insert into tbUsuario(NomeUsu, Cargo, Data)" + "values('{0}', '{1}', CONVERT(DATETIME,'{2}',103));", vNome, vCargo, vData);
//Banco.ExecutaComando(stringIns);

//Console.WriteLine("Conectado!");