﻿using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloContatos;
public class Contato : EntidadeBase
{
    public Contato(string nome, string telefone, string email, string empresa, string cargo)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
        Empresa = empresa;
        Cargo = cargo;
    }

    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string Empresa { get; set; }
    public string Cargo { get; set; }

    public override List<string> Validar()
    {
        List<string> erros = new List<string>();

        if (string.IsNullOrEmpty(Nome.Trim()))
            erros.Add("O campo \"nome\" é obrigatório.");

        if (string.IsNullOrEmpty(Telefone.Trim()))
            erros.Add("O campo \"telefone\" é obrigatório.");

        if (string.IsNullOrEmpty(Email.Trim()))
            erros.Add("O campo \"email\" é obrigatório.");

        if(string.IsNullOrEmpty(Empresa.Trim()))
            erros.Add("O campo \"empresa\" é obrigatório.");

        if(string.IsNullOrEmpty(Cargo.Trim()))
            erros.Add("O campo \"cargo\" é obrigatório.");

        return erros;
        }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        Contato Atualizado = (Contato)novoRegistro;

        Nome = Atualizado.Nome;
        Email = Atualizado.Email;
        Cargo = Atualizado.Cargo;
        Empresa = Atualizado.Empresa;
        Telefone = Atualizado.Telefone;
    }

    public override string ToString()
    {
        return Nome;
    }}
