//using UnityEditor;
//using UnityEditor.SceneManagement;
//using UnityEngine;
//
//[CustomEditor(typeof(SpawnerRegdolloverplayer))]
//public class SnowmanScriptEditor : Editor
//{
//    private SpawnerRegdolloverplayer script;
//
//    private void OnEnable()
//    {
//        script = (SpawnerRegdolloverplayer)target;
//    }
//
//
//    public override void OnInspectorGUI()
//    {
//        script.mintimespawn = EditorGUILayout.FloatField("мин время спавна короч", script.mintimespawn);
//        script.maxtimespawn = EditorGUILayout.FloatField("мaкс время спавна короч",script.maxtimespawn);
//
//        script.regdolls = (GameObject)EditorGUILayout.ObjectField("варианты", script.regdolls, typeof(GameObject), true);
//
//
//
//        script.lives = EditorGUILayout.FloatField("Жизки короче", script.lives);
//        script.Target = (GameObject)EditorGUILayout.ObjectField("за кем бегать",script.Target, typeof(GameObject), true);
//
//        script.isEvil = EditorGUILayout.Toggle("злой", script.isEvil);
//
//
//        if (script.isEvil)
//        {
//            script.sspoint = (GameObject)EditorGUILayout.ObjectField("где снежки спавнить", script.sspoint, typeof(GameObject), true);
//            script.psnow = (GameObject)EditorGUILayout.ObjectField("префаб снежка", script.psnow, typeof(GameObject), true);
//
//            script.ballspeed = EditorGUILayout.FloatField("скорость снежка", script.ballspeed);
//            script.firespeed = EditorGUILayout.FloatField("частота пиупиупиу", script.firespeed);
//        }
//
//
//
//
//
//        if (GUI.changed)
//        {
//            EditorUtility.SetDirty(script.gameObject);
//            EditorSceneManager.MarkSceneDirty(script.gameObject.scene);
//        }
//    }
//}
//