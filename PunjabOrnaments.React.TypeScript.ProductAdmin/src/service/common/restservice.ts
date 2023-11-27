import axios from "axios";

let myHeaders;

const POSTMethod = async <Type>(data: object, url: string) => {

    myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");

    const requestOptions: object = {
        method: 'POST',
        url: url,
        data: data,
        headers: myHeaders,
    };

    return await axios<Type>(url, requestOptions)
        .then(response => response)
        .catch((error) => console.log(error));
}

export {
    POSTMethod,
}