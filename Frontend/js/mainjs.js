// Titulos categoria 
let titleproducts = document.getElementById("category");
const allproducts = document.getElementById("allproducts");
const runnings = document.getElementById("runningshoes");
const basketball = document.getElementById("basketballshoes");
const training = document.getElementById("trainingshoes")

async function allproductsfun(){
    let reqData = await fetch(`http://localhost:5066/nike/Product`);
    let respuesta = await reqData.json();
    console.log(respuesta);
    allproducts.addEventListener("click",function()
    {
        titleproducts.textContent = "Todos los productos";
        renderproducts(respuesta);
    });
};

async function runningsshoes() {
    let reqData = await fetch(`http://localhost:5066/nike/Product/GetRunningShoes`)
    let respuesta = await reqData.json();
    runnings.addEventListener("click",function()
    {
        titleproducts.textContent = "Running Shoes";
        renderproducts(respuesta);
    });
};

async function basketballshoes(){
    let reqData = await fetch(`http://localhost:5066/nike/Product/GetBasketballShoes`);
    let respuesta = await reqData.json();

    basketball.addEventListener("click",function()
    {
        titleproducts.textContent = "Basketball Shoes";
        renderproducts(respuesta);
    });
};

async function trainingshoes(){
    let reqData = await fetch(`http://localhost:5066/nike/Product/GetCasualSneakers`);
    let respuesta = await reqData.json();
    training.addEventListener("click",function()
    {
        titleproducts.textContent = "Training Shoes";
        renderproducts(respuesta);
    });
};

function renderproducts(products) {
        try {
            const boxproducts2 = document.querySelector("#boxproducts2");
            boxproducts2.innerHTML = "";
            products.forEach(product => {
                const div = document.createElement("div");
                div.classList.add("productbox");
                div.innerHTML = /*html*/
                    `
                <img src="images/ShoesRunning1.jpg" alt="">
                <div class="infobox">
                    <p>${product.nameProduct}</p>
                    <div class="add">
                        <p>$ ${product.price}</p>
                        <button>Agregar</button>
                    </div>
                </div>
                `;
                boxproducts2.append(div);
            });
        } catch (error) {
            console.error('Error al obtener datos', error);
        };
};

runningsshoes();
allproductsfun();
basketballshoes();
trainingshoes();

