/**
 * 
 * Yan Ha Routhier-Chevrier
 * contenu de javascript pour la page accueil
 * 
 * */
$('.me-card').each(function (i, e) {
    // https://github.com/material-components/material-components-web/blob/master/docs/getting-started.md
    // attache à l'élément une joyeuse apparence 
    mdc.ripple.MDCRipple.attachTo(e);
});
