using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
public class TarefaController : Controller
{
    private static List<Tarefa> _tarefas = new List<Tarefa>();

    public IActionResult Index()
    {
        return View(_tarefas);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Adicionar(Tarefa novaTarefa)
    {
        //Verificando o total de tarefas de lista e somando mais 1 para criar o ID
        novaTarefa.Id = _tarefas.Count + 1;
        //Adicionando minha nova tarefa a minha lista 
        _tarefas.Add(novaTarefa);
        //Redirecionando para a página primcipal com a lista de tarefas 
        return RedirectToAction("Index");
    }

    public IActionResult Editar(int Id)
    {
        //Estou buscando na minha lista a tarefa que desejo alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
        //Verificar se ela existe
        if (novaTarefa == null)
            return NotFound();

        //Enviando para a View a tarefa que queremos alterar
        return View(novaTarefa);
    }

    [HttpPost]
    public IActionResult Editar(Tarefa tarefaEditado)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == tarefaEditado.Id);
        if (tarefaEncontrada == null)
            return NotFound();
        
        tarefaEncontrada.Descricao = tarefaEditado.Descricao;
        tarefaEncontrada.Concluida = tarefaEditado.Concluida;
        return RedirectToAction("Index");
    }

    public IActionResult Deletar(int Id)
    {
        //Estou buscando na minha lista a tarefa que desejo alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
        //Verificar se ela existe
        if (novaTarefa == null)
            return NotFound();

        //Enviando para a View a tarefa que queremos alterar
        return View(novaTarefa);
    }

    [HttpPost]
    public IActionResult DeletarConfirmado(int Id)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == Id);
        if (tarefaEncontrada == null)
            return NotFound();

        _tarefas.Remove(tarefaEncontrada);
        return RedirectToAction("Index");
    }
}

