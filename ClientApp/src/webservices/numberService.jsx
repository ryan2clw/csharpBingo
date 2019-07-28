import { handleResponse } from '../store/events';

const card = async (cardCount) => {
    const requestOptions = {
        method: 'GET'
    };
    const uri = "http://localhost:5000/api/Bingo/BingoCards?cardCount=" + cardCount;
    return fetch(uri, requestOptions)
        .then(handleResponse)
        .then(card => {
            console.log('API returned card', card);
            return card;
        })
}
const rounds = async () => {
    const requestOptions = {
        method: 'GET'
    };
    return fetch("http://localhost:5000/api/Bingo/Balls", requestOptions)
        .then(handleResponse)
        .then(rounds => {
            console.log('API returned rounds', rounds);
            return rounds;
        })
}
export const numberService = {
    card,
    rounds,
    round
};