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

let LoadAllUsers = async() => {


     let url = "";
     //const users = await ApiRequestGet(url);
}

let AddUser = async() => {


    let url = "";
    let userJSON = {
        ime: " ? ",
    };
    //ApiRequestPost(url,userJSON);
}

LoadAllUsers();

