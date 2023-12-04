import axios from "axios";

let myHeaders;

const POSTMethod = async (data, url) => {

    myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");

    const requestOptions = {
        method: 'POST',
        url: url,
        data: data,
        headers: myHeaders,
    };

    return await axios (url, requestOptions)
        .then(response => response)
        .catch((error) => console.log(error));
}

export {
    POSTMethod,
}