<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TareaDesarrolloWeb.web.Views.Inicio.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <div class="mb-0 mt-4">
        <i class="fa fa-newspaper-o"></i>Quizas esto te interese
    </div>
    <hr class="mt-1">
    <div class="form-row">
        <div class="col-md-5">
            <i class="fa fa-history"></i>¿Quieres publicar algo nuevo? 
                <br />
            <asp:TextBox runat="server" ID="txtPublicacion" CssClass="form-control" placeholder="Escribe algo..."></asp:TextBox>
            <a class="nav-link" href="#">
                <asp:FileUpload runat="server" ID="imgPublicacion" CssClass="form-control"></asp:FileUpload>
            </a>
            <asp:Button runat="server" ID="btnPublicar" CssClass="btn btn-outline-success" Text="Publicar" OnClick="btnPublicar_Click" />
        </div>
        <hr class="mt-0">
        <div class="col-md-7">
            <i class="fa fa-history"></i>Buscar 
                <br />
            <asp:TextBox runat="server" ID="txtBuscar" CssClass="form-control" placeholder="Buscar..."></asp:TextBox>
            <a class="nav-link" href="#">
                <i class="fa fa-fw fa-filter"></i>
                <span class="nav-link-text"></span>
                <asp:DropDownList runat="server" ID="dblCategoria">
                    <asp:ListItem Value=" "></asp:ListItem>
                    <asp:ListItem Value="Categoria">Automovil</asp:ListItem>
                    <asp:ListItem Value="Categoria">Celulares</asp:ListItem>
                    <asp:ListItem Value="Categoria">Muebles</asp:ListItem>
                    <asp:ListItem Value="Categoria">Electrodomesticos</asp:ListItem>
                </asp:DropDownList>
                <i class="fa fa-fw fa-calendar"></i>
                <span class="nav-link-text"></span>
                <asp:DropDownList runat="server" ID="dplTiempo">
                    <asp:ListItem Value=" "></asp:ListItem>
                    <asp:ListItem Value="Tiempo">Hoy</asp:ListItem>
                    <asp:ListItem Value="Tiempo">Ultima semana</asp:ListItem>
                    <asp:ListItem Value="Tiempo">Ultimo Mes</asp:ListItem>
                    <asp:ListItem Value="Tiempo">Todo</asp:ListItem>
                </asp:DropDownList>
                <i class="fa fa-fw fa-television"></i>
                <span class="nav-link-text"></span>
                <asp:DropDownList runat="server" ID="dplElectrodomesticos">
                    <asp:ListItem Value=" "></asp:ListItem>
                    <asp:ListItem Value="Electrodomesticos">1</asp:ListItem>
                    <asp:ListItem Value="Electrodomesticos">2</asp:ListItem>
                    <asp:ListItem Value="Electrodomesticos">3</asp:ListItem>
                </asp:DropDownList>
            </a>
        </div>
    </div>
    <hr class="mt-2">
    <div class="form-row">
        <div class="card-columns">
            <!-- Example Social Card-->
            <div class="card mb-3">
                <a href="#">
                    <asp:Image runat="server" Height="470px" Width="470px" ID="iPublicacion" ImageUrl="https://unsplash.it/700/450?image=610" />
                </a>
                <div class="card-body">
                    <asp:Label runat="server" ID="lblNombreUssPublicacion" Font-Italic="true" Font-Size="XX-Large"></asp:Label>
                    <br />
                    <asp:Label runat="server" ID="lblDescripcionArticulo"></asp:Label>
                </div>
                <hr class="my-0">
                <div class="card-body py-2 small">
                    <a class="mr-3 d-inline-block" href="#">
                        <i class="fa fa-fw fa-save"></i>Guardar</a>
                    <a class="mr-3 d-inline-block" href="#">
                        <i class="fa fa-fw fa-comment"></i>Contactar</a>
                    <a class="d-inline-block" href="#">
                        <i class="fa fa-fw fa-share"></i>Compartir</a>
                </div>
                <hr class="my-0">
                <div class="card-body small bg-faded">
                    <div class="media">
                        <img class="d-flex mr-3" src="http://placehold.it/45x45" alt="">
                        <div class="media-body">
                            <h6 class="mt-0 mb-1"><a href="#">Usuario</a></h6>
                            texto
                    <ul class="list-inline mb-0">
                        <li class="list-inline-item">
                            <a href="#">Like</a>
                        </li>
                    </ul>
                            <div class="media mt-3">
                                <a class="d-flex pr-3" href="#">
                                    <img src="http://placehold.it/45x45" alt="">
                                </a>
                                <div class="media-body">
                                    <h6 class="mt-0 mb-1"><a href="#">Comentario 1</a></h6>
                                    texto
                        <ul class="list-inline mb-0">
                            <li class="list-inline-item">
                                <a href="#">Like</a>
                            </li>
                        </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card-footer small text-muted">Publicado hace 30 minutos</div>
            </div>
        </div>
        <div class="card-columns">
            <!-- Example Social Card-->
            <div class="card mb-3">
                <a href="#">
                    <img class="card-img-top img-fluid w-100" src="https://unsplash.it/700/450?image=610" alt="">
                </a>
                <div class="card-body">
                    <asp:Label runat="server" ID="lblNombre" Text="Nombre de Usuario"></asp:Label>
                    <p class="card-text small">Texto de descripcion del articulo</p>
                </div>
                <hr class="my-0">
                <div class="card-body py-2 small">
                    <a class="mr-3 d-inline-block" href="#">
                        <i class="fa fa-fw fa-save"></i>Guardar</a>
                    <a class="mr-3 d-inline-block" href="#">
                        <i class="fa fa-fw fa-comment"></i>Contactar</a>
                    <a class="d-inline-block" href="#">
                        <i class="fa fa-fw fa-share"></i>Compartir</a>
                </div>
                <hr class="my-0">
                <div class="card-body small bg-faded">
                    <div class="media">
                        <img class="d-flex mr-3" src="http://placehold.it/45x45" alt="">
                        <div class="media-body">
                            <h6 class="mt-0 mb-1"><a href="#">Usuario</a></h6>
                            texto
                    <ul class="list-inline mb-0">
                        <li class="list-inline-item">
                            <a href="#">Like</a>
                        </li>
                    </ul>
                            <div class="media mt-3">
                                <a class="d-flex pr-3" href="#">
                                    <img src="http://placehold.it/45x45" alt="">
                                </a>
                                <div class="media-body">
                                    <h6 class="mt-0 mb-1"><a href="#">Comentario 1</a></h6>
                                    texto
                        <ul class="list-inline mb-0">
                            <li class="list-inline-item">
                                <a href="#">Like</a>
                            </li>
                        </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card-footer small text-muted">Publicado hace 30 minutos</div>
            </div>
        </div>
    </div>

</asp:Content>
