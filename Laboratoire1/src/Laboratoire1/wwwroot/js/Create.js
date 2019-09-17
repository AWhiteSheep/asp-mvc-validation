/**
 * 
 * Yan Ha Routhier-Chevrier
 * contenu javascript pour la page create
 * 
 * */

// ajout des regexp pour text et gender
jQuery.validator.addMethod("textonly", function (value, element) {
    return this.optional(element) || /^[a-zA-Z ]*$/.test(value);
}, 'S\'il vous plaît veuillez rentrer seulement que des lettres et espaces.');

jQuery.validator.addMethod("genderonly", function (value, element) {
    return this.optional(element) || /^M|m|f|F$/.test(value);
}, 'La valeur ne peut être correct.');

// valide le formulaire
$("#myform").validate({
    rules: {
        num_evaluation: {
            required: true,
            number: true
        },
        nom_eleve: {
            required: true,
            textonly: true
        },
        prenom_eleve: {
            required: true,
            textonly: true
        },
        telephone_eleve: {
            required: true,
            phoneUS: true
        },
        courriel_eleve: {
            required: true,
            email: true
        },
        genre_eleve: {
            required: true,
            genderonly: true
        },
        note_evaluation: {
            required: true
        },
        date_evaluation: {
            required: true,
            date: true
        },
        commentaires_evaluation: {
            required: true,
            textonly: true
        }
    }
});
