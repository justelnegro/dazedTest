const largestArrangement = array => {
    const result = array.sort((current, next) => parseInt(current.toString() + next.toString()) > parseInt(next.toString() + current.toString()) ? -1 : 1);
    return parseInt(result.join(''));
}

