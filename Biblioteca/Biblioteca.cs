﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        List<Livro> livros;
        List<Usuario> usuarios;
        List<Emprestimo> emprestimos;

        public Biblioteca() 
        {
            this.livros = new List<Livro>();
            this.usuarios = new List<Usuario>();
            this.emprestimos = new List<Emprestimo>();
        }

        public void carregarDados()
        {
            //TODO carregar os dados nas listas
        }
        public void salvarDados()
        {
            //TODO salvar dados das listas
        }

        private Usuario selecionarUsuario() 
        {
            if (usuarios.Count == 0) {
                Console.WriteLine("Não existem usuários cadastrados no sistema!");
                return null;
            }
            Usuario usuario = usuarios[0];
            //TODO permitir a seleção de usuários...
            return usuario;
        }

        private Livro selecionarLivro() 
        {
            if (livros.Count == 0){
                Console.WriteLine("Não existem livros cadastrados no sistema!");
                return null;
            }
            Livro livro = livros[0];
            //TODO permitir a seleção de livros...
            return livro;
        }

        private Emprestimo selecionarEmprestimo()
        {
            if (emprestimos.Count == 0) {
                Console.WriteLine("Não existem emprestimos cadastrados no sistema!");
                return null; 
            }
            Emprestimo emprestimo = emprestimos[0];
            //TODO permitir a seleção de emprestimos...
            return emprestimo;
        }

        public void cadastrarLivro()
        {
            Livro novolivro = new Livro();
            if (livros.Count == 0) novolivro.id = 1;
            else novolivro.id = livros.Max(q => q.id) + 1;

            Console.Clear();
            ConsoleUtils.WriteTitle("Adicionando novo Livro");
            ConsoleUtils.WriteTitle("Dados da Obra");
            Console.Write("\n");
            novolivro.autor = ConsoleUtils.textField("Autor");
            novolivro.titulo = ConsoleUtils.textField("Titulo");
            novolivro.edicao = ConsoleUtils.textField("Edição");
            novolivro.anoPublicacao = ConsoleUtils.numericField("Ano de Publicação",30,1900);
            
            ConsoleUtils.WriteTitle("Localização do volume no acervo");
            Console.Write("\n");
            novolivro.corredor = ConsoleUtils.numericField("Corredor", 30,1);
            novolivro.estante = ConsoleUtils.numericField("Estante", 30, 1);
            novolivro.prateleira = ConsoleUtils.numericField("Prateleira", 30, 1);
            
            livros.Add(novolivro);
            
            Console.WriteLine("\n\nNovo livro adicionado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void marcarLivroComoPerdido() 
        {
            Livro livro = selecionarLivro();
            if (livro == null) return;
            livro.perdido = true;
            salvarDados();
        }
        public void marcarLivroComoDestruido() 
        {
            Livro livro = selecionarLivro();
            if (livro == null) return;
            livro.destruido = true;
            salvarDados();
        }

        public void atualizarDadosDoLivro() 
        {
            Livro livro = selecionarLivro();
            if (livro == null) return;
            //TODO preencher os novos dados do livro
            salvarDados();
        }

        public void cadastrarNovoUsuario() 
        {
            Usuario novoUsuario = new Usuario();
            if (usuarios.Count == 0) novoUsuario.id = 1;
            else novoUsuario.id = usuarios.Max(q => q.id) + 1;
            //TODO preencher os dados do usuário
            usuarios.Add(novoUsuario);
            salvarDados();
        }

        public void atualizarCadastroUsuario() 
        {
            Usuario usuario = selecionarUsuario();
            if(usuario == null) return;

            salvarDados();
        }
        public void banirUsuario() 
        {
            Usuario usuario = selecionarUsuario();
            if (usuario == null) return;
            usuario.banido = true;
            salvarDados();
        }

        public void emprestarLivro() 
        {
            Livro livro = selecionarLivro();
            if (livro == null) return;

            Usuario usuario = selecionarUsuario();
            if (usuario == null) return;

            Emprestimo novoEmprestimo = new Emprestimo();
            if (emprestimos.Count == 0) novoEmprestimo.id = 1;
            else novoEmprestimo.id = emprestimos.Max(q => q.id)+1;

            novoEmprestimo.idLivro = livro.id;
            novoEmprestimo.idUsuario = usuario.id;
            livro.disponivel = false;
            novoEmprestimo.dataDevolucao = novoEmprestimo.dataEmprestimo.AddDays(3);

            emprestimos.Add(novoEmprestimo);
            salvarDados();
        }
        public void devolverLivro() 
        {
            Emprestimo emprestimo = selecionarEmprestimo();
            if (emprestimo == null) return;

            foreach (Livro livro in livros)
            {
                if (livro.id == emprestimo.idLivro) 
                {
                    livro.disponivel=true;
                }
            }
            emprestimo.dataDevolucao = DateTime.Now;
            emprestimo.devolvido = true;
        }


    }
}
