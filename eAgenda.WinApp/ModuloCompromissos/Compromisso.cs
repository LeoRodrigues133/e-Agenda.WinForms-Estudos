using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContatos;

namespace eAgenda.WinApp.ModuloCompromissos;
public class Compromisso : EntidadeBase
{
    public Compromisso(string assunto,
                       DateTime data,
                       TimeSpan horaInicio,
                       TimeSpan horaTermino,
                       bool marcarContato,
                       Contato? contatoMarcado,
                       string local)
    {
        Assunto = assunto;
        Data = data;
        HoraInicio = horaInicio;
        HoraTermino = horaTermino;
        MarcarContato = marcarContato;
        ContatoMarcado = contatoMarcado;
        Local = local;
    }

    public string Assunto { get; set; }
    public DateTime Data { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraTermino { get; set; }
    public bool MarcarContato { get; set; }
    public Contato? ContatoMarcado { get; set; }
    public tipoCompromissoEnum TipoCompromisso { get; set; } 
    public string Local { get; set; }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        Compromisso Atualizado = (Compromisso)novoRegistro;

        Assunto = Atualizado.Assunto;
        Data = Atualizado.Data;
        HoraInicio = Atualizado.HoraInicio;
        HoraTermino = Atualizado.HoraTermino;
        MarcarContato = Atualizado.MarcarContato;
        ContatoMarcado = Atualizado.ContatoMarcado;
        TipoCompromisso = Atualizado.TipoCompromisso;
        Local = Atualizado.Local;

    }

    public override List<string> Validar()
    {
        List<string> erros = new List<string>();

        if (Data == null)
            erros.Add("O campo \"data\" é obrigatório.");

        if (HoraInicio == null)
            erros.Add("O campo \"início\" é obrigatório.");

        if (HoraTermino == null)
            erros.Add("O campo \"início\" é obrigatório.");

        if (MarcarContato == true && ContatoMarcado == null)
            erros.Add("O campo de \"contato\" deve ser preenchido.");

        if (TipoCompromisso == tipoCompromissoEnum.Presencial && Local == string.Empty)
            erros.Add("O campo destinado ao \"local\" deve ser preenchido.");

        if (TipoCompromisso == tipoCompromissoEnum.Remoto && Local == string.Empty)
            erros.Add("O campo destinado ao \"link\" deve ser preenchido.");

        return erros;

    }
    public override string? ToString()
    {
        return $"Id: {Id}," +
            $" Assunto: {Assunto}," +
            $" Data {Data.ToString("dd/MM/yy")}," +
            $" Início: {HoraInicio.ToString(@"hh\:mm")}," +
            $" Término {HoraTermino.ToString(@"hh\:mm")}," +
            $" Contato: {ContatoMarcado?.Nome}," +
            $"Local: {Local} ";

    }
}
