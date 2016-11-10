if (typeof String.prototype.capitalise !== "function") {
    String.prototype.capitalise = function () {
        return this.charAt(0).toUpperCase() + this.slice(1);
    }
}

if (typeof String.prototype.camelCaseToSpineCase !== "function") {
    String.prototype.camelCaseToSpineCase = function () {
        return this.replace(/[-]/g, ' ') // switch dashes to spaces
                   .replace(/(?!^)([A-Z])/g, ' $1')
                   .replace(/[_\s]+(?=[a-zA-Z])/g, '-').toLowerCase()
    }
}

if (typeof String.prototype.spineCaseToCamelCase !== "function") {
    String.prototype.spineCaseToCamelCase = function () {
        return this.trim()
            .replace(/\s+/g, ' ')
            .replace(/[ ]/g, '-')
                   .replace(/(\-\w)/g, function (m) { return m[1].toUpperCase(); });
    }
}

if (typeof String.prototype.format !== "function") {
    String.prototype.format = function () {
        var args = arguments;
        return this.replace(/{(\d+)}/g, function (match, number) {
            return typeof args[number] != 'undefined'
              ? args[number]
              : match
            ;
        });
    }
}