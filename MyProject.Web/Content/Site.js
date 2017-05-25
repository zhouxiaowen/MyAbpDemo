
(function ($) {
$.dataTablesToAbpInput = function (request, settings) {
    var input = {};
    input.Sequence = request.draw;
    input.SkipCount = (request.start != null) ? request.start : 0;
    input.MaxResultCount = (request.length != null) ? request.length : settings._iDisplayLength;
    return input;
},

$.dataTablesFromAbpOutput = function (input, output, settings) {
    var response = {};
    response.draw = input.Sequence;
    response.recordsTotal = output.totalCount;
    response.recordsFiltered = output.totalCount;
    response.data = output.items;
    return response;
}

})(jQuery);