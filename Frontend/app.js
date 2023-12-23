let ApiRequestGet = async (url) => {
    const promise = await fetch(url, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer '
        }
    });
    if (promise.status != 200)
        alert(promise.status);
    return await promise.json();
}

let ApiRequestPost = async (url, data) => {
    const promise = await fetch(url, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer '
        },
        body: JSON.stringify(data)
    });
    if (promise.status != 200)
        alert(promise.status);
}

let LoadAllUsers = async () => {

    let url = "http://localhost:5139/api/User/VratiSve";
    let users = await ApiRequestGet(url);

    let article = document.getElementById("article");

    for(let i=0;i<users.length;i++){
        
        let h4Ime = document.createElement("h4");
        let h4God = document.createElement("h4");
        h4Ime.innerHTML = "Ime: " + users[i].ime + " " + users[i].prezime;
        h4God.innerHTML = "Godine do penzije: " + users[i].doPenzije;
        article.appendChild(h4Ime);
        article.appendChild(h4God);
    }
    
    
}

let AddUser = async () => {

    let txt1 = document.getElementById("txt1");
    let txt2 = document.getElementById("txt2");
    let txt3 = document.getElementById("txt3");
    let txt4 = document.getElementById("txt4");

    let url = "http://localhost:5139/api/User/Dodaj";
    let userJSON = {
        ime: txt1.value,
        prezime: txt2.value,
        godine: txt3.value,
        radniStaz: txt4.value,
        doPenzije: 0
    };
    ApiRequestPost(url,userJSON);
}

LoadAllUsers();

