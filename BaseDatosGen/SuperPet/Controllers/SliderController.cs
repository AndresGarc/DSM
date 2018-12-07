using BaseDatosGenNHibernate.CAD.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.EN.BaseDatos;
using SuperPet.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperPet.Controllers
{
    public class SliderController : BasicController
    {
        // GET: Slider
        public ActionResult Index()
        {
            //EJEMPLO CON EL CEN
            SessionInitialize();
            SliderCAD sliCAD = new SliderCAD(session);
            SliderCEN sliCEN = new SliderCEN(sliCAD);
            IList<SliderEN> listSliEN = sliCEN.MuestraSliders(0,-1);
            IEnumerable<Slider> lista = new AssemblerSlider().ConvertListENToModel(listSliEN).ToList();
            SessionClose();
            return View(lista);
        }
        // GET: Slider/Edit/
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            SliderEN sliEN = new SliderCAD(session).MuestraSliderPorOID(id);
            Slider sli = new AssemblerSlider().ConvertENToModelUI(sliEN);
            return View(sli);
        }

        // POST: Slider/Edit/5
        [HttpPost]
        public ActionResult Edit(Slider sli, HttpPostedFileBase file1)
        {
            string fileName = "", path = "";
            // Verify that the user selected a file
            if (file1 != null && file1.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file1.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file1.SaveAs(path);


                try
                {
                    fileName = "/Images/Slider/" + fileName;
                    SliderCEN cen = new SliderCEN();
                    cen.CambiarImagen(sli.Id, 0, fileName);
                    //cen.New_(art.Descripcion, art.Precio, art.IdCategoria, fileName, art.Nombre);

                    SessionInitialize();
                    SliderCAD sliCAD = new SliderCAD();
                    SliderCEN sliCEN = new SliderCEN(sliCAD);
                    sliCEN.CambiarImagen(sli.Id, 0, fileName);
                    SessionClose();

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            return RedirectToAction("Index");
                 /*
                 String file = collection[1];// nombre del archivo
                 String file2 = collection[0];// nombre del archivo
                 String file3 = collection[3];// nombre del archivo


                 SliderCEN cen = new SliderCEN();
                 cen.CambiarImagen(id, 1, file);
                 cen.CambiarImagen(id, 0, file2);
                 cen.CambiarImagen(id, 2, file3);
                 return RedirectToAction("Index");
                 //cen.New_(art.Descripcion, art.Precio, art.IdCategoria, fileName, art.Nombre);
                 */
                    /*
                    foreach (var key in collection.AllKeys)
                    {
                        collection[key];
                    }

                    return RedirectToAction("Index");
                    */
                    /*
                    int i = 0;
                    foreach (HttpPostedFileBase file in files) {

                        string fileName = "", path = "";
                        // Verify that the user selected a file
                        if (file != null && file.ContentLength > 0)
                        {
                            // extract only the fielname
                            fileName = Path.GetFileName(file.FileName);
                            // store the file inside ~/App_Data/uploads folder
                            path = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                            //string pathDef = path.Replace(@"\\", @"\");
                            file.SaveAs(path);


                            try
                            {


                                fileName = "/Images/Uploads/" + fileName;
                                ProductoCEN cen = new ProductoCEN();
                                cen.Modify(prod.id, prod.Nombre, fileName, prod.Precio, prod.Stock,prod.ValoracionMedia,prod.Destacado,prod.Oferta);


                                fileName = "/Images/Slider/" + fileName;
                                SliderCEN cen = new SliderCEN();
                                cen.CambiarImagen(sli.Id, i, fileName);
                                //cen.New_(art.Descripcion, art.Precio, art.IdCategoria, fileName, art.Nombre);

                                return RedirectToAction("Index");
                            }
                            catch
                            {
                                return View();
                            }
                        }
                        ++i;
                    }
                    */
                    //return RedirectToAction("Index");
                }

    }
}
