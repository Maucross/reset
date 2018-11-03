function abrirEnPestana(url)
{
    var a = document.createElement("a");
    a.target = "_blank";
    a.href = url;
    a.click();
}
var url = "MantenerCliente";
window.onload = function()
{
    abrirEnPestana(url);
}