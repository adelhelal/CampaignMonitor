
// Extension method stripHtml for string object
String.prototype.stripHtml = function () {
    return this.replace(new RegExp(/<[^>]+>/g), "");
};
