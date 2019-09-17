/**
 * 
 * Yan Ha Routhier-Chevrier
 * contenu javascript pout la view list
 * 
 * */

/**
 *
 * Activé lors de l'évévenement click elle se sert des attributs data-* afin
 * de nourir la modal qui s'ouvrira par la suite
 * 
 */
function etudiantShow(e, i) {
    var title = $(e).attr("data-evaluation-numero");
    var prenom = $(e).attr("data-evaluation-prenom");
    var nom = $(e).attr("data-evaluation-nom");
    var telephone = $(e).attr("data-evaluation-telephone");
    var courriel = $(e).attr("data-evaluation-courriel");
    var genre = $(e).attr("data-evaluation-genre");
    var note = $(e).attr("data-evaluation-note");
    var date = $(e).attr("data-evaluation-date");
    var commentaire = $(e).attr("data-evaluation-commentaire");

    switch (genre) {
        case "M":
            genre = "Homme";
            break;
        case "F":
            genre = "Femme";
            break;
        default:
            break;
    }

    $("h5[class='modal-title']").text(title);
    $("#modal-num").text(title);
    $("#modal-nom").text(nom);
    $("#modal-prenom").text(prenom);
    $("#modal-evaluation-telephone").text(telephone);
    $("#modal-courriel").text(courriel);
    $("#modal-genre").text(genre);
    $("#modal-note").text(note);
    $("#modal-date").text(date);
    $("#modal-commentaire").text(commentaire);

    // présente la modal
    $("#modal").modal('show');
};
