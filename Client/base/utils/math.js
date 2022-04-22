export function intervalIntersectsWith(int1, int2) {
    return !(int1[1] <= int2[0] || int2[1] <= int1[0]);
}
export function intervalContains(int1, int2) {
    return int1[0] <= int2[0] && int2[1] <= int1[1];
}
