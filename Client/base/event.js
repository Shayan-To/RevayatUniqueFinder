export class Event {
    constructor() {
        this.listeners = [];
        this.data = [];
    }
    addListener(listener, data) {
        this.listeners.push(listener);
        this.data.push(data);
        return this.removeListener.bind(this, listener);
    }
    removeListener(listener) {
        const i = this.listeners.findIndex(l => l === listener);
        if (i !== -1) {
            this.listeners.splice(i, 1);
            this.data.splice(i, 1);
        }
    }
    forEachListener(action) {
        for (let i = 0; i < this.listeners.length; i += 1) {
            if (action(this.listeners[i], this.data[i]) === false) {
                break;
            }
        }
    }
}
