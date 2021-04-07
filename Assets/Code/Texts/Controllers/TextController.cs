using Interfaces;
using Quests;
using UnityEngine;


namespace Texts
{
    public class TextController : IInitializable
    {
        private TextModel _textModel;
        private TextView _textView;
        private IQuestAndTextProvider _questAndTextProvider;
        public TextController(TextModel textModel, TextView textView, IQuestAndTextProvider questAndTextProvider)
        {
            this._textModel = textModel;
            this._textView = textView;
            this._questAndTextProvider = questAndTextProvider;
            _questAndTextProvider.OnGameObjectGet += GetGameObject;
        }

        private GameObject GetGameObject()
        {
            return _textView.gameObject;
        }

        

        private void ActivateText()
        {
            _textView.gameObject.SetActive(true);
        }

        public void Initialize()
        {

        }
    }
}
