<!DOCTYPE html>
<html>
<head>
    <body>
        <h1>Contactar</h1>
        <form action="/my-handling-form-page" method="post">
            <ul>
    <li>
      <label for="name">Para:</label>
      <input type="text" id="destinatario" name="user_destinatario">
    </li>
    <li>
      <label for="mail">Temática:</label>
      
      <select name="Temática" id="tematica">
        <option value="consulta">---Elige un análisis---</option>
        <option value="consulta">Salmonella spp</option>
        <option value="propuesta">E coli 0157</option>
        <option value="reporte">Listeria monocytogenes</option>
        <option value="otros">Otros</option>
      </select>
      
    </li>
    <li>
      <label for="msg">Asunto:</label>
      <textarea id="msg" name="user_asunto"></textarea>
    </li>
    <li>
        <label for="msg">Cuerpo:</label>
        <textarea id="msg" name="user_cuerpo"></textarea>
        
      </li>
      <input type="submit" value="Enviar este formulario">

</form>
   </ul>
   
  </form>

        </form>
    </body>
</html>