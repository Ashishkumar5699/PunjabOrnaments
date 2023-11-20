const GETAsync = async (url, authdetail) => {
    console.log("AuthService is working")
}

const POSTAsync = async (url, raw) => {
    var myHeaders = new Headers();
myHeaders.append("Content-Type", "application/json");

var raw = JSON.stringify({
  "username": "string",
  "password": "string"
});

var requestOptions = {
  method: 'POST',
  headers: myHeaders,
  body: raw,
  redirect: 'follow'
};

console.log("===============================================================================")
await fetch("https://localhost:5001/api/Account/login", requestOptions)
  .then(response => response.text())
  .then(result => console.log(result))
  .catch(error => console.log('error', error));
  console.log("===============================================================================")
}
    const POSTAsyncc = async (url, raw) => {
    var requestOptions = {
        method: 'POST',
        headers: AddHeader(),
        body: raw,
        // redirect: 'follow'
    };
    
    var response = Consume(url, requestOptions)
    var result = HandleResponse(response)
    return result;

}

const PUTAsync = async (url, authdetail) => {
    console.log("AuthService is working")
}

const DELETEAsync = async (url, authdetail) => {
    console.log("AuthService is working")
}

const Consume = async (url, requestOptions) => {
    fetch(url, requestOptions)
    .then(response => response.text())
    .then(result => console.log(result))
    .catch(error => console.log('error', error));
}

const AddHeader = () => {
    var myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");
    myHeaders.append('Accept', 'application/json');
    myHeaders.append('Origin',"http://localhost:5173");
    return myHeaders;
}

const HandleResponse = (response) =>{
    return response;
}

export{
    GETAsync,
    POSTAsync,
    PUTAsync,
    DELETEAsync
}