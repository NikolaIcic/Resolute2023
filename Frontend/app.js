let MyFunction = () => {
    let username = document.getElementById("input1");
    console.log(username.value);

    let password = document.getElementById("input2");
    console.log(password.value);

    let niz = ['Nikola','Ognjen','Nata','Bojan','Anta'];

    let article = document.getElementById("article");

    let ul = document.createElement("ul");

    for(let i=0;i<niz.length;i++){
        let li = document.createElement("li");
        li.innerHTML = niz[i];
        ul.appendChild(li);
    }

    article.appendChild(ul);
}