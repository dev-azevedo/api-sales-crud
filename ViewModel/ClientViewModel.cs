﻿using System.ComponentModel.DataAnnotations;

namespace CamposDealerCrud.ViewModel;

public class ClientPostViewModel
{
    [Required(ErrorMessage = "O campo nome é obrigatório")]
    public string Name { get; set; }
    [Required(ErrorMessage = "O campo cidade é obrigatório")]
    public string City { get; set; }
}

public class ClientPutViewModel
{
    [Required(ErrorMessage = "O campo id do cliente é obrigatório")]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "O campo nome é obrigatório")]
    public string Name { get; set; }
    [Required(ErrorMessage = "O campo cidade é obrigatório")]
    public string City { get; set; }
}

public class ClientRespViewModel {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}
