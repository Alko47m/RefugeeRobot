#!/usr/bin/python
# coding=utf8

#NOTE: THIS IS AN EXACT PORT OF THE VBA CODE. NOT MY CODE, NOT MY LOGIC, JUST MY TRANSLATION.
#  -Alex G

from flask import Flask
from flask import abort
from flask import jsonify
from flask import request

app = Flask(__name__)

languages = [
    {
        'id': 'english',
        'phrases': ['Hello! I am the Refugee Robot.','Word not recognized. Please try again.','The store is downtown, I will take you there.'],
        'keywords': ['Hello', 'Hi', 'Hey', 'Where', 'Store']
    },
    {
        'id': 'french',
        'phrases': ['Salut! Je suis le Robot de réfugiés.','Mot non reconnu. S’il vous plaît essayer de nouveau.','Le magasin se trouve au centre-ville, je vous y serez.'],
        'keywords': ['Bonjour', 'Salut', 'Hallo', 'Ou', 'Magasin']

    },
    {
        'id': 'spanish',
        'phrases': ['¡Hola! Yo soy el Robot de refugiados.','Palabra no reconocida. Por favor, inténtelo de nuevo.','La tienda está en el centro. Te llevaré allí'],
        'keywords': ['Hola', 'Vale', 'Hoy', 'Donde', 'Tienda']
    }
]

@app.route('/talk', methods=['POST']) #TODO add UID system?
def talk():
    if not request.json or not 'text' in request.json or not 'language' in request.json:
        abort(400)
    ret = [language for language in languages if language['id'] == request.json['language']]
    if len(ret) == 0:
        return jsonify({'language': 'unknown', 'response': 'That language is not supported yet! ごめんなさい!'})
    return jsonify({'language': request.json['language'], 'response': phrase(request.json['text'], ret[0])})

def phrase(text, dic):
    #here there be ugly hardcoding
    #if you're expanding the app, maybe make the keywords a sorted dictionary -
    #NOT AN ARRAY!
    for i in range(0,3):
        if dic['keywords'][i].lower() in text.lower():
            return dic['phrases'][0]
    for i in range(3,5):
        if dic['keywords'][i].lower() in text.lower():
            return dic['phrases'][2]
    else:
        return dic['phrases'][1]

if __name__ == '__main__':
    app.run(debug=True)
