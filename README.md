Proyecto asp.net core api
version de .Net 10

    • GET /breeds :

Debe retornar una lista de las razas de gatos.

    • GET /breeds/:breed_id

Debe retornar únicamente la raza de gato solicitada

    • GET /breeds/search:

Debe retornar la información asociada a la consulta realizada de acuerdo a los parámetros.

Controlador imágenes:

El controlador debe tener 1 accion:

    • GET /imagesbybreedid :

Debe retornar las imágenes asociadas a una raza especifica de gato.

Controlador Usuarios:

El controlador debe tener 2 acción:

    • GET /login :

Debe permitir verificar en una colección de Mongo la existencia de un usuario y validar su contraseña y retorna la información del usuario.
    • GET /Register :

    
