const http = require("node:http");
const { arch } = require("node:os");
const puerto = 3000;

var archivo = {
    papitas : [
        {
            nombre : "Incógnito",
            precio : 30,
            marca : "Doritos"
        },
        {
            nombre : "Originales",
            precio : 17,
            marca : "Takis"
        },
    ]
}

const server = http.createServer((request, response) => {

    response.setHeader("Access-Control-Allow-Methods", "GET", "POST", "PUT", "DELETE");

    if(request.method = "GET"){
        response.statusCode = 200;
        response.setHeader("Content-Type", "application/json");
        response.end(JSON.stringify(archivo));
    }

    if(request.method == "POST"){
        request.on("data", info => {
            const nuevas_papitas = JSON.parse(info);
            archivo.papitas.push(nuevas_papitas);

            response.statusCode = 201;
            response.setHeader("Content-Type", "application/json");
            response.end("Papitas creadas exitosamente");
        });
    }
    if(request.method = "PUT"){
        request.on("data", info => {
            const papitas_mofiadas = JSON.parse(info);
            console.log(papitas_mofiadas);

            archivo.papitas[papitas_mofiadas.indice] = {
                marca: papitas_mofiadas.marca,
                nombre: papitas_mofiadas.nombre,
                precio: papitas_mofiadas.precio
            }

            response.statusCode = 200;
            response.setHeader("Content-Type", "application/json");
            response.end("Papitas modificadas exitosamente");

        });
    }

    if(request.method == "DELETE"){
        const indice = request.url.replace("/", "");
        archivo.papitas.splice(indice, 1)

        response.statusCode = 200;
            response.setHeader("Content-Type", "application/json");
            response.end("Papitas borradas exitosamente");
    }

    if(request.method == "OPTIONS"){
        response.writeHead(204);
        response.end();
    }
    
});

server.listen(puerto, () => {
    console.log("Servidor a la escucha en http://localhost:" + puerto);
});