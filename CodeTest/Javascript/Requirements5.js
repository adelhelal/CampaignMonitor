
// Extension method startsWith for string object
String.prototype.startsWith = function (value) {
    return this.indexOf(value) != -1;
};

// Extension method endsWith for string object
String.prototype.endsWith = function (value) {
    return this.indexOf(value, this.length - value.length) != -1;
};
