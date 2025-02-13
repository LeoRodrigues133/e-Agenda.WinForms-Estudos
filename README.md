# e-Agenda_1.0

O **e-Agenda_1.0** é um sistema desenvolvido para gerenciar compromissos e contatos de forma eficiente. Criado durante estudos baseados no curso proposto pela Academia do programador 2024, o projeto utiliza a arquitetura **MVC (Model-View-Controller)** em **WinForms** para organizar e estruturar o código de maneira modular e reutilizável.

O sistema permite o cadastro e gerenciamento de compromissos e contatos, além de fornecer funcionalidades como edição, exclusão e filtragem. Ele facilita a organização pessoal e profissional dos usuários.

---

## 📌 Requisitos Funcionais

- Permitir o cadastro, edição e exclusão de **compromissos**.
- Permitir o cadastro, edição e exclusão de **contatos**.
- Listar os compromissos existentes e aplicar filtros de visualização.
- Listar os contatos cadastrados.
- Exibir notificações e mensagens padronizadas para os usuários.

---

## 🔧 Requisitos Não Funcionais

### **Persistência das Informações**
- Os dados são gerenciados por um **repositório**, garantindo melhor organização e manutenção.

### **Arquitetura**
- O sistema segue o padrão **MVC** para separar responsabilidades entre Modelo, Visão e Controle.

### **Interface Gráfica**
- Desenvolvido em **WinForms**, garantindo uma interface interativa e intuitiva.
- Os dados são exibidos utilizando **DataGridView** para melhor visualização.
- As telas seguem um layout padronizado, mantendo consistência e usabilidade.

---

## 🛠️ Requisitos

- **.NET SDK** (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
- **Visual Studio** (recomendado) para um ambiente de desenvolvimento completo.

---

## 🚀 Como Usar

### Clone o Repositório
```
git clone https://github.com/academia-do-programador/e-agenda-1.0.git
```

### Navegue até a pasta raiz do projeto
```
cd e-agenda-1.0
```

### Restaure as dependências
```
dotnet restore
```

### Navegue até a pasta do projeto
```
cd eAgenda.WinApp
```

### Execute o projeto
```
dotnet run
```
