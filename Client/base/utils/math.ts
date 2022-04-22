/**
 * [inclusive start, exclusive end]
 */
export type IntegerInterval = [start: number, end: number];

export function intervalIntersectsWith(int1: IntegerInterval, int2: IntegerInterval) {
    return !(int1[1] <= int2[0] || int2[1] <= int1[0]);
}

export function intervalContains(int1: IntegerInterval, int2: IntegerInterval) {
    return int1[0] <= int2[0] && int2[1] <= int1[1];
}
