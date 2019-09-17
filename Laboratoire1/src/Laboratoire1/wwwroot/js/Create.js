/**
 * 
 * Yan Ha Routhier-Chevrier
 * contenu javascript pour la page create
 * 
 * */

// ajout des regexp pour text et gender
jQuery.validator.addMethod("textonly", function (value, element) {
    return /^([A-Z])[a-zA-Z \-]+$/.test(value);
}, 'S\'il vous plaît veuillez rentrer seulement que des lettres et espaces.');

jQuery.validator.addMethod("genderonly", function (value, element) {
    return /^H|h|f|F$/.test(value);
}, 'La valeur ne peut être correct.');

// valide le formulaire
$("#myform").validate({
    rules: {
        num_evaluation: {
            required: true,
            min:0,
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
            required: true,
            min: 0,
            max: 100
        },
        date_evaluation: {
            required: true,
            date: true,
            max: document.getElementsByTagName("time").item(0).getAttribute("data-date")
        },
        commentaires_evaluation: {
            required: true,
            textonly: true
        }
    },
    messages: {
        num_evaluation: {
            required: "Le numéro est obligatoire.",
            min: "Ce champ doit être plug grand ou égale 0.",
            number: "Ce champ doit être un numéro."
        },
        nom_eleve: {
            required: "Le nom est obligatoire.",
            textonly: "Ce champ doit être du text et commencer par une majuscule."
        },
        prenom_eleve: {
            required: "Le prénom est obligatoire.",
            textonly: "Ce champ doit être du text et commencer par une majuscule."
        },
        telephone_eleve: {
            required: "Le téléphone est obligatoire.",
            phoneUS: "Ce champ est un numéro de téléphone."
        },
        courriel_eleve: {
            required: "Le courriel est obligatoire.",
            email: "Ce champ doit être un courriel."
        },
        genre_eleve: {
            required: "Le genre est obligatoire.",
            genderonly: "Genre inconnu."
        },
        note_evaluation: {
            required: "La note est obligatoire.",
            min : "Le champ doit être au moins à 0.",
            max : "Le champ peu être au maximum 100."
        },
        date_evaluation: {
            required: "La date est obligatoire.",
            date: true,
            max: "La date doit être plus petite ou égale à " + document.getElementsByTagName("time").item(0).getAttribute("data-date")
        },
        commentaires_evaluation: {
            required: "Le commentaire est obligatoire.",
            textonly: "Ce champ doit être du text et commencer par une majuscule."
        }
    }
});
