app.controller("popularCreativeController", function ($scope, creativeService) {

    creativeServise.getPopularCreatives($scope);

});

app.controller("newCreativeController", function ($scope, creativeService) {

    creativeServise.getNewCreatives($scope);

});