import { handleResponse } from '../store/events';

const card = async () => {
    const requestOptions = {
        method: 'GET'
    };
    return fetch("http://localhost:5000/api/Bingo/BingoCard", requestOptions)
        .then(handleResponse)
        .then(card => {
            // store user details and jwt token in local storage to keep user logged in between page refreshes
            console.log('API returned card', card);
            return card;
        })
}
export const numberService = {
    card,
};